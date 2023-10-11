import { useState, useEffect } from 'react';
import axios from 'axios';
import { useParams } from 'react-router-dom';

const InstrumentDetail = () => {

	const [teacherList, setTeacherList] = useState([]);
	const {instrument} = useParams();

	// Write useEffect to get all teachers that teach the selected instrument

	return (
		<div className="teacher-cards">
			{
				teacherList.map((teacher, index) => (
					<div className="teacher-card">
						<p>{teacher.firstName} {teacher.lastName}</p>
					</div>
				))
			}
		</div>
	)
}

export default InstrumentDetail;
