import React, { useState } from 'react';
import useApi from '../Hooks/useApi';
import axios from 'axios';

const LessonBookingModal = ({ teacher, isModalVisible, closeModal, bookLesson, instrumentId }) => {
  const [lesson, setLesson] = useState({
    teacherId: 1,
    studentId: 1,
    instrumentId: instrumentId,
    durationMinutes: 0,
    bookingDate: ""
  })
  const url = "/api/lesson"

  const { handleSubmit } = useApi();

  const handleManualSubmit = async (e) => {
    e.preventDefault();
    handleSubmit(url, lesson, "POST");
  }

  const handleChange = (e) => {
    setLesson({ ...lesson, [e.target.name]: e.target.value });
  };

  return (
    isModalVisible && (
      <div className="modal" style={{ display: 'block' }}>
        <div className="modal-content">
          <button onClick={closeModal}>Close</button>
          <h2>{teacher.name}</h2>
          {/* Lesson booking form */}
          <form onSubmit={(e)=>handleManualSubmit(e)}>
            <div>
              <label htmlFor="lessonDate">Lesson Date:</label>
              <input
                type="datetime-local"
                id="lessonDate"
                name="bookingDate"
                value={lesson.bookingDate}
                onChange={handleChange}
              />
            </div>
            <div>
              <label htmlFor="durationMinutes">Duration: </label>
              <input
                type="number"
                id="durationMinutes"
                name="durationMinutes"
                value={lesson.durationMinutes}
                onChange={handleChange}
              />
            </div>
            <button type="submit">Book Lesson</button>
          </form>
        </div>
      </div>
    )
  );
};

export default LessonBookingModal;
