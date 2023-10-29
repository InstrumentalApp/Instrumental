import { useState } from 'react';
import { useLocation } from 'react-router-dom';

const LessonBookingSuccess = () => {

  const { state } = useLocation();

  return (
    // Will come back to clean up and beautify the information displayed here
    <div>
      <h2>Lesson Confirmed!</h2>
      <p>{state.bookingDate}</p>
      <p>Student: {state.student.firstName} {state.student.lastName}</p>
      <p>Teacher: {state.teacher.firstName} {state.teacher.lastName}</p>
    </div>
  )
}

export default LessonBookingSuccess;
