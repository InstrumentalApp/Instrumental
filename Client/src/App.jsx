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
import SuperUserDashboard from './Components/SuperUserDashboard';
import useApi from './Hooks/useApi';
import useLocalStorage from './Hooks/useLocalStorage';

function App() {

  const [hello, setHello] = useState("");
  const { handleSubmit } = useApi();

  const fetchData = async () => {
    const result = handleSubmit("/api/auth/hello", {}, "GET")
    setHello(result.data);
  }

  useEffect(() => {
    fetchData()
    console.log(hello)
    const handleScroll = () => {
      setScrollTop(window.scrollY);
    };

    window.addEventListener('scroll', handleScroll);

    return () => {
      window.removeEventListener('scroll', handleScroll);
    };
  }, [])

  const [scrollTop, setScrollTop] = useState(0);
  const { handleSubmit, data } = useApi();
  const [credentials, setCredentials] = useLocalStorage("credentials", {});

  return (
    <div className='flex-col-center' style={{
      backgroundColor: style.colors.TERTIARY,
      minHeight:"100vh",
      height: "fit-content",
      justifyContent: "space-between"
    }}
    >
      <NavBar scrollPosition={scrollTop}/>
      <Routes>
        <Route path="/" element={<LandingPage />} />
        <Route path="/instruments" element={<InstrumentLessonsOffered />} />
        <Route path="/instruments/:instrumentId" element={<InstrumentDetail />} />
        <Route path="/sign-in" element={<Login />} />
        <Route path="/register" element={<Register />} />
        {credentials && Object.keys(credentials).length > 0 ? (
          <Route path="/admin/dashboard" element={<SuperUserDashboard />} />
        ) : null}
      </Routes>
      <Footer/>
    </div>
  )
}

export default App
