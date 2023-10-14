import { useState, useEffect } from 'react';
import axios from 'axios';
import { useParams, useNavigate } from 'react-router-dom';

const InstrumentDetail = () => {

	const [teacherList, setTeacherList] = useState([]);
	const [bookingModalVisible, setBookingModalVisible] = useState(false);
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

	  const handleBookLesson = async (teacher) => {
		const accessToken = localStorage.getItem('credentials')?.accessToken;
		if (accessToken) {
		  try {
			const response = await axios.post('/api/auth/verify', { token: accessToken });
			if (response.data.valid) {
			  setBookingModalVisible(true);
			} else {
			  navigate('/signup');
			}
		  } catch (error) {
			console.error("Error verifying token:", error);
		  }
		} else {
		  navigate('/signup');
		}
	  };

	return (
		<div className="teacher-cards">
			{
				teacherList.map((teacher, index) => (
					<div className="teacher-card">
						<p>{teacher.firstName} {teacher.lastName}</p>
						<button onClick={() => handleBookLesson(teacher)}>Book a Lesson</button>
					</div>
				))
			}
		</div>
	)
}

export default InstrumentDetail;
