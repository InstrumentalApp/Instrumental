import React, { useState } from 'react';

const LessonBookingModal = ({ teacher, isModalVisible, closeModal, bookLesson }) => {
  const [lessonDate, setLessonDate] = useState('');
  const [lessonTime, setLessonTime] = useState('');
  const [additionalInfo, setAdditionalInfo] = useState('');

  const handleBookLesson = () => {
    // Implement the booking logic here
    // You can use lessonDate, lessonTime, additionalInfo, and teacher data
    // If booking is successful, call the bookLesson function to close the modal
  };

  return (
    isModalVisible && (
      <div className="modal" style={{ display: 'block' }}>
        <div className="modal-content">
          <button onClick={closeModal}>Close</button>
          <h2>{teacher.name}</h2>

          {/* Lesson booking form */}
          <form onSubmit={handleBookLesson}>
            <div>
              <label htmlFor="lessonDate">Lesson Date:</label>
              <input
                type="date"
                id="lessonDate"
                value={lessonDate}
                onChange={(e) => setLessonDate(e.target.value)}
              />
            </div>
            <div>
              <label htmlFor="lessonTime">Lesson Time:</label>
              <input
                type="time"
                id="lessonTime"
                value={lessonTime}
                onChange={(e) => setLessonTime(e.target.value)}
              />
            </div>
            <div>
              <label htmlFor="additionalInfo">Additional Information:</label>
              <textarea
                id="additionalInfo"
                value={additionalInfo}
                onChange={(e) => setAdditionalInfo(e.target.value)}
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
