import { useState, useEffect } from 'react';
import axios from 'axios';
import { useParams, useNavigate } from 'react-router-dom';
import LessonBookingModal from './LessonBookingModal';


const InstrumentDetail = () => {

	const [teacherList, setTeacherList] = useState([]);
	const [bookingModalVisible, setBookingModalVisible] = useState(false);
	const [selectedTeacher, setSelectedTeacher] = useState(null);
	const {instrumentId} = useParams();
	const navigate = useNavigate();

	// Write useEffect to get all teachers that teach the selected instrument

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

	//   const handleBookLesson = async (teacher) => {
	// 	const accessToken = localStorage.getItem('credentials')?.accessToken;
	// 	if (accessToken) {
	// 	  try {
	// 		const response = await axios.post('/api/auth/verify', { token: accessToken });
	// 		if (response.data.valid) {
	// 		  setBookingModalVisible(true);
	// 		} else {
	// 		  navigate('/signup');
	// 		}
	// 	  } catch (error) {
	// 		console.error("Error verifying token:", error);
	// 	  }
	// 	} else {
	// 	  navigate('/sign-in');
	// 	}
	//   };

	    // Open the modal without token authentication
		const openModal = (teacher) => {
			console.log("Opening modal with teacher: ", teacher);
			setSelectedTeacher(teacher); // Store the selected teacher
			setBookingModalVisible(true);
		  };

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
