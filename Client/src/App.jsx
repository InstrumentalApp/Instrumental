import { useEffect, useState } from 'react'
import './App.css'
import axios from 'axios';
import InstrumentComponent from './Components/Instrument';

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
      <div><InstrumentComponent /></div>
    </>
  )
}

export default App
