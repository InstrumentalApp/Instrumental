import { useState, useEffect } from 'react';
import axios from 'axios';
import { useParams, useNavigate } from 'react-router-dom';
import "../Styles/InstrumentLessons.css";
import useLocalStorage from '../Hooks/useLocalStorage';
import LessonBookingModal from './LessonBookingModal';
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import HoverButton from "./HoverButton";
import Typography from '@mui/material/Typography';
import styles from "../Styles/App";
import Skeleton from '@mui/material/Skeleton';
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
      navigate('/instrumental/sign-in');
    }
  };

  const closeModal = async () => {
    setBookingModalVisible(false);
  }


  return (
    <div className="teacher-cards">
      {
        teacherList.map((teacher, index) => (
          <Card key={index} className="teacher-card" sx={{
            maxWidth: 345,
            backgroundColor: styles.colors.SECONDARY,
            transition: "translate .2s, box-shadow .25s",
            padding: 2,
            marginTop: 4,
          }}>
            {/* Add pictures for teachers, adjust colors */}
            <CardMedia
              sx={{ height: 100, p: 10, m: 2 }}
              image="https://placehold.co/300"
            />
            <CardContent sx={{ color: "black" }}>
              <Typography gutterBottom variant="body1" component="div" sx={{ fontFamily: styles.fonts.HEADER_FONT }}>
                {teacher.firstName} {teacher.lastName}
              </Typography>
            </CardContent>
            <CardActions className="d-flex justify-content-center">
              <HoverButton
                onClick={() => openModal(teacher)}
                backgroundColor={styles.colors.SECONDARY}
                color={styles.colors.BLACK}
                fontSize="12px"
              >
                Book a Lesson
              </HoverButton>
            </CardActions>
          </Card>
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
