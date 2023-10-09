import { useEffect, useState } from 'react'
import './App.css'
import axios from 'axios';
import NavBar from './Components/NavBar';
import Login from './Components/Login';
import { Route, Routes } from 'react-router-dom';
import Example from './Components/Example';
import Register from "./Components/Register";

function App() {

  const [hello, setHello] = useState("");

  const fetchData = async () => {
    const result = await axios.get("/api/auth/hello")
    setHello(result.data);
  }

  useEffect(() => {
    fetchData()
    console.log(hello)
  }, [])

  return (
    <>
      <NavBar />
      <Routes>
        <Route path="/hello" element={<Example />} />
        <Route path="/sign-in" element={<Login />} />
        <Route path="/register" element={<Register />} />
      </Routes>
    </>
  )
}

export default App
