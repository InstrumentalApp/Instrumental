import { useState, useEffect } from 'react';
import axios from 'axios';
import { useParams, useNavigate } from 'react-router-dom';
import useLocalStorage from '../Hooks/useLocalStorage';
import LessonBookingModal from './LessonBookingModal';
import useApi from '../Hooks/useApi';


const InstrumentDetail = () => {

  const [teacherList, setTeacherList] = useState([]);
  const [bookingModalVisible, setBookingModalVisible] = useState(false);
  const [selectedTeacher, setSelectedTeacher] = useState({});
  const { instrumentId } = useParams();
  const [credentials, setCredentials] = useLocalStorage("credentials", {})
  const navigate = useNavigate();

  useEffect(() => {
    const fetchTeachers = async () => {
      try {
        const response = await axios.get(`/api/instructor/${instrumentId}/instructors`);
        setTeacherList(response.data);
        console.log(response.data)
      } catch (error) {
        console.error("Error fetching teacher list:", error);
      }
    };

    fetchTeachers();
  }, []);

  const openModal = async (teacher) => {
    // Check if there is an accessToken in the credentials
    console.log(teacher);
    console.log(credentials);
    if (credentials && credentials.accessToken) {
      setSelectedTeacher(teacher);
      setBookingModalVisible(true);
      console.log("Booking Modal Visible");
    } else {
      // If there's no accessToken, you might want to handle it, e.g., navigate to a sign-in page
      navigate('/sign-in');
    }
  };

  const closeModal = async () => {
    setBookingModalVisible(false);
  }


  return (
    <div className="teacher-cards">
      {
        teacherList.map((teacher, index) => (
          <div key={index} className="teacher-card">
            <p>{teacher.firstName} {teacher.lastName}</p>
            <button onClick={() => openModal(teacher)}>Book a Lesson</button>
          </div>
        ))
      }
      {/* Conditionally render the LessonBookingModal */}
      <LessonBookingModal
        teacher={selectedTeacher} // Pass the selected teacher to the modal
        isModalVisible={bookingModalVisible}
        closeModal={() => setBookingModalVisible(false)} // Function to close the modal
        bookLesson={() => {
          // Implement the bookLesson function if needed
          // It can include booking a lesson with the selected teacher
          // and closing the modal
        }}
        instrumentId={instrumentId}
      />

    </div>
  )
}

export default InstrumentDetail;
