import axios from "axios";
import { useEffect, useRef, useState } from "react";
import { Link } from "react-router-dom";
import "../Styles/InstrumentLessons.css";
<<<<<<< Updated upstream
import { TextField } from "@mui/material";
=======
import TextField from "@mui/material/TextField";
import Container from "@mui/material/Container";
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import styles from "../Styles/App";
import Skeleton from '@mui/material/Skeleton';
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
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
=======
        {loading ?
        placeholders.map((index) => (
          <Card key={index} elevation={0} className="instrument-card" sx={{ 
          maxWidth: 345, 
          backgroundColor: styles.colors.SECONDARY, 
          paddingBottom: 2,
          }}>
            <Skeleton sx={{ height: 160, backgroundColor: styles.colors.FORM }} animation="wave" variant="rectangular"/>
            <CardContent>
              <div className="d-flex flex-column align-items-center gap-2">
                <Skeleton height={30} width="80%" animation="wave" />
                <Skeleton height={20} width="60%" animation="wave" />
              </div>
            </CardContent>
            <CardActions className="d-flex justify-content-center">
              <Skeleton height={35} width="60%" animation="wave" variant="rounded" />
            </CardActions>
          </Card>
        )) :
        instrumentList.map((instrument, index) => (
          <Card key={index} elevation={0} className="instrument-card" sx={{ 
          maxWidth: 345, 
          backgroundColor: styles.colors.SECONDARY, 
          paddingBottom: 2,
          }}>
            <CardMedia
            sx={{ height: 160 }}
            image="https://placehold.co/100"
            title={instrument.name}
            />
            <CardContent>
              <Typography gutterBottom variant="h6" component="div" sx={{ fontFamily: styles.fonts.HEADER_FONT }}>
                {instrument.name}
              </Typography>
              <Typography variant="body2" color="text.secondary">
                {instrument.family}
              </Typography>
            </CardContent>
            <CardActions className="d-flex justify-content-center">
              <Button size="small" 
              variant="outlined" 
              href={"/instruments/" + instrument.instrumentId}
              disableElevation
              color="success"
              sx={{ textTransform: "none" }}
              >
                Learn More
              </Button>
            </CardActions>
          </Card>
>>>>>>> Stashed changes
        ))}
      </div>
    </div>
  );
};

export default InstrumentLessonsOffered;
