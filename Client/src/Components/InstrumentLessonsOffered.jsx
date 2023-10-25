import axios from "axios";
import { useEffect, useRef, useState } from "react";
import { Link } from "react-router-dom";
import "../Styles/InstrumentLessons.css";
import { TextField } from "@mui/material";

const InstrumentLessonsOffered = () => {
  // API Call to Back-End When Data Gets Updated

  const [instrumentList, setInstrumentList] = useState([]);
  const unfilteredList = useRef([]);
  const [searchInput, setSearchInput] = useState("");

  const fetchInstrumentList = async () => {
    try {
      const result = await axios.get("/api/instrument/all");
      setInstrumentList(result.data);
      unfilteredList.current = result.data;
    } catch (error) {
      // Handle error here (e.g., show an error message)
      console.error("Error fetching instrument list:", error);
    }
  };

  // Fetches instrument list and saves reference to unfiltered list on page render
  useEffect(() => {
    fetchInstrumentList();
  }, []);

  const handleSearchInput = (e) => {
    setSearchInput(e.target.value);
  };

  // Sets state of displayed instrument list using user's search input and filtering through original, unfiltered list
  useEffect(() => {
    const filteredOptions = unfilteredList.current.filter((instrument) =>
      instrument.name.toLowerCase().includes(searchInput.toLowerCase())
    );
    setInstrumentList(filteredOptions);
  }, [searchInput]);

  return (
    <div className="instrument-lessons-offered">
      <div className="d-flex justify-content-center flex-wrap">
        <h2 className="heading">Instruments Lessons Offered</h2>
        <TextField
          sx={{
            mb: 4,
          }}
          size="small"
          placeholder="Search instruments..."
          onChange={(e) => handleSearchInput(e)}
        />
      </div>
      <div className="instrument-cards">
        {instrumentList.map((instrument, index) => (
          <div key={index} className="instrument-card">
            {/* Not sure if we want to keep links routing to IDs or to instrument names */}
            <Link to={"/instruments/" + instrument.instrumentId}>
              <img
                className="instrument-image"
                src="https://placehold.co/100"
                alt="placeholder"
              />
              <h6>{instrument.name}</h6>
            </Link>
          </div>
        ))}
      </div>
    </div>
  );
};

export default InstrumentLessonsOffered;
