import { Link } from '@mui/material';
import React from 'react'
import { Link as RouterLink, useLocation } from 'react-router-dom';
import styles from '../Styles/App';

const TeacherCreationSuccess = () => {
  const { state } = useLocation();

  return (
    <div>
    <h2>Your teacher has been created!</h2>
    <p>{Date.now}</p>
    <p>Name: {state.firstName} {state.lastName}</p>
    <p>Email: {state.email}</p>
    <Link component={RouterLink} to={"/"} underline="hover" variant="body2"
      sx={{
        color: styles.colors.PRIMARY,
        fontWeight: "bold",
        opacity: .7
      }}
    >
      Return Home
    </Link>
  </div>
  )
}

export default TeacherCreationSuccess
