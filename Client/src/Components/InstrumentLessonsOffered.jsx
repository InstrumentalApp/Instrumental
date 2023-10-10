import axios from 'axios';
import { useState } from 'react';
import { Link } from 'react-router-dom';

const InstrumentLessonsOffered = () => {
  // Hard Coded Instrument List to Get Started
  const instruments = [
    { name: 'Piano', url: '/teachers/piano' },
    { name: 'Guitar', url: '/teachers/guitar' },
    { name: 'Bass', url: '/teachers/bass' },
    { name: 'Voice', url: '/teachers/voice' },
    { name: 'Banjo', url: '/teachers/banjo' },
    { name: 'Harmonica', url: '/teachers/harmonica' },
  ];

  // API Call to Back-End When Data Gets Updated

  const [instrumentList, setInstrumentList] = useState([]);

  const fetchInstrumentList = async () => {
    try {
      const result = await axios.get("/api/instrument/all");
      setInstrumentList(result.data);
    } catch (error) {
      // Handle error here (e.g., show an error message)
      console.error("Error fetching instrument list:", error);
    }
  }

  return (
    <div className="instrument-lessons-offered">
      <h2>Instruments Lessons Offered</h2>
      <div className="instrument-cards">
        {instruments.map((instrument, index) => (
          <div key={index} className="instrument-card">
            <Link to={instrument.url}>
              <h3>{instrument.name}</h3>
              <p>Find {instrument.name} Teachers</p>
            </Link>
          </div>
        ))}
      </div>
    </div>
  );
};

export default InstrumentLessonsOffered;
