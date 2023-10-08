import { useState, useEffect } from "react";
import axios from "axios";
import useLocalStorage from "./useLocalStorage";

const useApi = (initialUrl, initialJwt, method = "GET", body = null) => {
  const [data, setData] = useState(null);
  const [url, setUrl] = useState(initialUrl);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState(null);
  const [credentials, setCredentials] = useLocalStorage("credentials", {});

  useEffect(() => {
    const fetchData = async () => {
      setLoading(true);
      setError(null);

      const headers = {
        Authorization: `Bearer ${initialJwt}`,
        "Content-Type": "application/json",
      };

      const config = {
        method: method,
        url: url,
        headers: headers,
        data: body,
      };
      try {
        const result = await axios(config);
        setData(result.data);
      } catch (err) {
        // Assume 401 is the unauthorized status code.
        if (err.response && err.response.status === 401) {
          try {
            const refreshToken = localStorage.getItem("refreshToken");
            const refreshResponse = await axios.post("/api/auth/refresh", {
              token: refreshToken,
            });
            const accessToken = refreshResponse.data.accessToken;
            const newRefreshToken = refreshResponse.data.refreshToken;
            // Store the new access token for future requests
            setCredentials({
              "accessToken": accessToken,
              "refreshToken": newRefreshToken
            })

            // Retry the original request with the new token
            headers["Authorization"] = `Bearer ${accessToken}`;
            const retryResult = await axios.get(url, { headers });
            setData(retryResult.data);
          } catch (refreshErr) {
            setError(refreshErr);
            // Redirect to login or handle logout
          }
        } else {
          setError(err);
        }
      }

      setLoading(false);
    };

    if (url) {
      fetchData();
    }
  }, [url, initialJwt]);

  return { data, loading, error, setUrl };
};

export default useApi;
