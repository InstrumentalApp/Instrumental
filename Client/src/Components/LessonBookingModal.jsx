import { useEffect, useState } from 'react';
import useApi from '../Hooks/useApi';
import axios from 'axios';
import useLocalStorage from "../Hooks/useLocalStorage";
import { useNavigate } from "react-router-dom";

const LessonBookingModal = ({ teacher, isModalVisible, closeModal, bookLesson, instrumentId }) => {

  const [lesson, setLesson] = useState({})
  const [credentials, setCredentials] = useLocalStorage("credentials", {});
  const navigate = useNavigate();
  const url = "/api/lesson"

  useEffect(() => {
    if (teacher && credentials) {
      setLesson({
        teacherId: teacher.userId,
        studentId: credentials["userId"],
        instrumentId: instrumentId,
        durationMinutes: 0,
        bookingDate: ""
      })
    }
  }, [teacher])

  const { data, handleSubmit } = useApi();

  const handleManualSubmit = async (e) => {
    e.preventDefault();
    console.log(lesson);
    if (lesson.durationMinutes <= 0) {
      alert("Duration should be a positive number");
    }
      else {
        handleSubmit(url, lesson, "POST");
      }
  };
  
  useEffect(() => {
    if (data) {
      navigate('/instrumental/bookingsuccess', { state: data });
    }
  }, [data])

  const handleChange = (e) => {
    setLesson({ ...lesson, [e.target.name]: e.target.value });
  };

  return (
    isModalVisible && (
      <div className="modal" style={{ display: 'block' }}>
        <div className="modal-content">
          <button onClick={closeModal}>Close</button>
          <h2>{teacher.firstName}</h2>
          <h2>{teacher.lastName}</h2>
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
