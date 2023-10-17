import { useEffect, useState } from 'react'
import './Styles/App/App.css'
import axios from 'axios';
import { Route, Routes, useParams } from 'react-router-dom';
import style from "./Styles/App";
import NavBar from './Components/NavBar';
import Login from './Components/Login';
import LandingPage from './Components/LandingPage';
import InstrumentLessonsOffered from './Components/InstrumentLessonsOffered';
import Footer from './Components/Footer'
import Register from "./Components/Register";
import InstrumentDetail from './Components/InstrumentDetail';

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
    <div style={{ backgroundColor: style.colors.TERTIARY, height: "100vh" }}>
      <NavBar />
      <Routes>
        <Route path="/" element={<LandingPage />} />
        <Route path="/instruments" element={<InstrumentLessonsOffered />} />
        <Route path="/instruments/:instrumentId" element={<InstrumentDetail />} />
        <Route path="/sign-in" element={<Login />} />
        <Route path="/register" element={<Register />} />
      </Routes>
      <Footer/>
    </div>
  )
}

export default App
