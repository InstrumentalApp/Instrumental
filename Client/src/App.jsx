import { useEffect, useState } from 'react'
import './Styles/App/App.css'
import style from "./Styles/App";
import { Route, Routes, Navigate, Outlet } from 'react-router-dom';
import NavBar from './Components/NavBar';
import Login from './Components/Login';
import LandingPage from './Components/LandingPage';
import InstrumentLessonsOffered from './Components/InstrumentLessonsOffered';
import NotFoundPage from './Components/NotFoundPage';
import Footer from './Components/Footer'
import Register from "./Components/Register";
import InstrumentDetail from './Components/InstrumentDetail';
import LessonBookingSuccess from './Components/LessonBookingSuccess';
import Account from './Components/Account';
import SuperUserDashboard from './Components/SuperUserDashboard';
import useLocalStorage from './Hooks/useLocalStorage';

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

  const PageLayout = () => (
    <div className='flex-col-center' style={{
      backgroundColor: style.colors.TERTIARY,
      minHeight:"100vh",
      height: "fit-content",
      justifyContent: "space-between"
    }}>
      <NavBar scrollPosition={scrollTop} />
      <Outlet />
      <Footer />
    </div>
  );

  return (
    <>
      <Routes>
        <Route element={<PageLayout />}>
          <Route path="/" element={<Navigate to="/instrumental" />} />
          <Route path="/instrumental" element={<LandingPage />} />
          <Route path="/instrumental/instruments" element={<InstrumentLessonsOffered />} />
          <Route path="/instrumental/instruments/:instrumentId" element={<InstrumentDetail />} />
          <Route path="/instrumental/bookingsuccess" element={<LessonBookingSuccess />} />
          <Route path="/instrumental/sign-in" element={<Login />} />
          <Route path="/instrumental/register" element={<Register />} />
          {/*
          Implement logic to allow access to this route when a user is logged in.
          We would also need to conditionally render a Sign In or View Account button
          in the Navbar component depending on if a user is currently logged in.
          */}
          <Route path="/instrumental/account" element={<Account />} />
          {credentials && Object.keys(credentials).length > 0 ? (
            <Route path="/admin/dashboard" element={<SuperUserDashboard />} />
          ) : null}
        </Route>
        <Route path="*" element={<NotFoundPage />} />
      </Routes>
    </>
  )
}

export default App
