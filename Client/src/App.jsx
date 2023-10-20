import { useEffect, useState } from 'react'
import './Styles/App/App.css'
import style from "./Styles/App";
import axios from 'axios';
import { Route, Routes, useParams } from 'react-router-dom';
import NavBar from './Components/NavBar';
import Login from './Components/Login';
import LandingPage from './Components/LandingPage';
import InstrumentLessonsOffered from './Components/InstrumentLessonsOffered';
import Footer from './Components/Footer'
import Register from "./Components/Register";
import InstrumentDetail from './Components/InstrumentDetail';
import Account from './Components/Account';

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

        {/* 
        Implement logic to allow access to this route when a user is logged in.
        We would also need to conditionally render a Sign In or View Account button
        in the Navbar component depending on if a user is currently logged in.
        */}
        <Route path="/account" element={<Account />} />

      </Routes>
      <Footer/>
    </div>
  )
}

export default App
