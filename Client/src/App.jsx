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
import HowItWorks from './Components/HowItWorks';
import TeachWithUs from './Components/TeachWithUs';
import LessonBookingSuccess from './Components/LessonBookingSuccess';
import Account from './Components/Account';
import SuperUserDashboard from './Components/SuperUserDashboard';
import useLocalStorage from './Hooks/useLocalStorage';
import SuperUserNav from './Components/SuperUserNav';
import CreateTeacher from './Components/CreateTeacher';
import TeacherCreationSuccess from './Components/TeacherCreationSuccess';

function App() {

  useEffect(() => {
    const handleScroll = () => {
      setScrollTop(window.scrollY);
    };

    window.addEventListener('scroll', handleScroll);

    return () => {
      window.removeEventListener('scroll', handleScroll);
    };
  }, [])

  const [scrollTop, setScrollTop] = useState(0);
  const [credentials, setCredentials] = useLocalStorage("credentials", {});

  return (
    <div className='flex-col-center' style={{
      backgroundColor: style.colors.TERTIARY,
      minHeight:"100vh",
      height: "fit-content",
      justifyContent: "space-between"
    }}
    >
      <div style={{
        width: "100%"
      }}>
      <NavBar scrollPosition={scrollTop} />
      {credentials && Object.keys(credentials).length > 0 && credentials["role"]=="SUPERUSER" ? (
          <SuperUserNav />
        ) : null}
      </div>
      <Routes>
        <Route path="/" element={<LandingPage />} />
        <Route path="/instruments" element={<InstrumentLessonsOffered />} />
        <Route path="/how-it-works" element={<HowItWorks />} />
        <Route path="/teach-with-us" element={<TeachWithUs />} />
        <Route path="/instruments/:instrumentId" element={<InstrumentDetail />} />
        <Route path="/bookingsuccess" element={<LessonBookingSuccess />} />
        <Route path="/sign-in" element={<Login />} />
        <Route path="/register" element={<Register />} />

        {/*
        Implement logic to allow access to this route when a user is logged in.
        We would also need to conditionally render a Sign In or View Account button
        in the Navbar component depending on if a user is currently logged in.
        */}
        <Route path="/account" element={<Account />} />

        {credentials && Object.keys(credentials).length > 0 && credentials["role"]=="SUPERUSER" ? (
          <>
          <Route path="/admin/dashboard" element={<SuperUserDashboard />} />
          <Route path="/admin/teachers/create" element={<CreateTeacher />} />
          <Route path="/teacher_creation_success" element={<TeacherCreationSuccess />} />
          </>
        ) : null}
      </Routes>
      <Footer/>
    </div>
  )
}

export default App
