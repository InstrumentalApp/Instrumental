import { useState } from 'react';
import axios from 'axios';
import useLocalStorage from "./useLocalStorage";

const useApi = () => {
  const [data, setData] = useState(null);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState(null);
  const [credentials, setCredentials] = useLocalStorage("credentials", {});

  const getHeaders = (accessToken) => ({
    Authorization: `Bearer ${accessToken}`,
    "Content-Type": "application/json",
  });

  const fetchData = async (givenUrl, bodyData, givenMethod, accessToken) => {
    const headers = getHeaders(accessToken);
    const config = {
      method: givenMethod,
      url: givenUrl,
      headers: headers,
      data: bodyData,
    };
    return await axios(config);
  };

  const refreshTokenAndRetry = async (originalConfig) => {
    const refreshToken = credentials["refreshToken"];
    const refreshResponse = await axios.post("/api/auth/refresh", {
        token: refreshToken,
    });
    const accessToken = refreshResponse.data.accessToken;
    const newRefreshToken = refreshResponse.data.refreshToken
    setCredentials({...credentials,"accessToken":accessToken, "refreshToken":newRefreshToken});
    originalConfig.headers["Authorization"] = `Bearer ${accessToken}`;

    return axios(originalConfig);
  };

  const fetchDataWrapper = async (givenUrl, bodyData, givenMethod) => {
    setLoading(true);
    setError(null);

    try {
      const result = await fetchData(givenUrl, bodyData, givenMethod, credentials["accessToken"] || "");
      setData(result.data);
    } catch (err) {
        if (err.response && err.response.status === 401) {
            try {
                const retryResult = await refreshTokenAndRetry({
                    method: givenMethod,
                    url: givenUrl,
                    headers: getHeaders(credentials["accessToken"]),
                    data: bodyData
                });
                setData(retryResult.data);
            } catch (refreshErr) {
                setError(refreshErr);
            }
        } else {
            setError(err);
        }
    }
    setLoading(false);
  };

  const handleSubmit = (givenUrl, givenData, givenMethod) => {
    fetchDataWrapper(givenUrl, givenData, givenMethod);
  };

  return { data, loading, error, handleSubmit };
};

export default useApi;
