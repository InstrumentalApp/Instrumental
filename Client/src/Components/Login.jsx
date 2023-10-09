import React, { useState } from 'react';
import useLocalStorage from '../Hooks/useLocalStorage';
import { useNavigate } from 'react-router-dom';
import axios from "axios"

const Login = () => {
  const [errors, setErrors] = useState([]);
  const navigate = useNavigate();
  const [loginUser, setLoginUser] = useState({
    email: "",
    password: ""
  });

  const [credentials, setCredentials] = useLocalStorage("credentials", {});

  const handleChange = (e) => {
    setLoginUser({ ...loginUser, [e.target.name]: e.target.value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      const result = await axios.post("/api/auth/login", loginUser)
      setCredentials(result.data);
    } catch (err) {
      const errorData = err.response.data.errors || err.response.data
      const errorMessages = Object.values(errorData).flat();
      setErrors(errorMessages);
    }
  };

  return (
    <>
      <h1>Login</h1>
      {
        errors.map((v, i) => <p key={i}>{v}</p>)
      }
      <form onSubmit={handleSubmit}>
        <input
          type="text"
          name="email"
          placeholder="Email"
          value={loginUser.email}
          onChange={handleChange}
        />
        <input
          type="password"
          name="password"
          placeholder="Password"
          value={loginUser.password}
          onChange={handleChange}
        />
        <button type="submit">Login</button>
      </form>
    </>
  );
}

export default Login;
