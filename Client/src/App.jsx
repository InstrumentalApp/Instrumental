import { useEffect, useState } from 'react'
import './App.css'
import axios from 'axios';
import NavBar from './Components/NavBar';

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
      <h1>{hello}</h1>
      <NavBar/>
    </>
  )
}

export default App
