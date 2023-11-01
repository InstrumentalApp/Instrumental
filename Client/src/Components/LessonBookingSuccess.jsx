import { useState } from 'react';
import styles from '../Styles/App';
import { useLocation, Link as RouterLink } from 'react-router-dom';
import Link from "@mui/material/Link";

const LessonBookingSuccess = () => {

  const { state } = useLocation();
  var d = new Date(state.bookingDate);
  var dateString = d.toLocaleTimeString([],
    { year: 'numeric', month: 'numeric', day: 'numeric', hour: '2-digit', minute: '2-digit' }
  );

  return (
    // Will come back to clean up and beautify the information displayed here
    <div>
      <h2>Your lesson has been confirmed!</h2>
      <p>{dateString}</p>
      <p>Student: {state.student.firstName} {state.student.lastName}</p>
      <p>Teacher: {state.teacher.firstName} {state.teacher.lastName}</p>
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

export default LessonBookingSuccess;
