import axios from "axios";
import { useEffect, useRef, useState } from "react";
import "../Styles/InstrumentLessons.css";
import Container from "@mui/material/Container";
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import HoverButton from "./HoverButton";
import Typography from '@mui/material/Typography';
import styles from "../Styles/App";
import Skeleton from '@mui/material/Skeleton';
import SearchIcon from '@mui/icons-material/Search';
import instrumentImages from "../Assets/Instruments";
import ExpandLessIcon from '@mui/icons-material/ExpandLess';
import ExpandMoreIcon from '@mui/icons-material/ExpandMore';

const InstrumentLessonsOffered = () => {
  // API Call to Back-End When Data Gets Updated

  const [instrumentList, setInstrumentList] = useState([]);
  const [seeAll, setSeeAll] = useState(false); // This will be used to display all instruments when user clicks on "See All"
  const unfilteredList = useRef([]);
  const [searchInput, setSearchInput] = useState("");
  const [loading, setLoading] = useState(true);
  const placeholders = Array.from({ length: 20 }, (_, i) => i + 1);

  const fetchInstrumentList = async () => {
    try {
      const result = await axios.get("/api/instrument/all");
      const withImage = result.data.filter(instrument => instrument.name.toLowerCase().replace(' ','') in instrumentImages).sort((a, b) => a.name.localeCompare(b.name))
      const withoutImage = result.data.filter(instrument => !(instrument.name.toLowerCase().replace(' ','') in instrumentImages)).sort((a, b) => a.name.localeCompare(b.name))
      setInstrumentList(withImage.concat(withoutImage));
      unfilteredList.current = instrumentList;
      setLoading(false);
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
    const filteredOptions = unfilteredList.current.filter((instrument) => {
      if(instrument.name.toLowerCase().includes(searchInput.toLowerCase())) return true; 
      if(instrument.family.toLowerCase().includes(searchInput.toLowerCase())) return true;
    }
    );
    setInstrumentList(filteredOptions);
  }, [searchInput]);

  // This will create the effect of highlighting current card
  const hoverStyle = {
    translate: "-5px -5px 0",
    boxShadow: `5px 5px 0 ${styles.colors.PRIMARY}`, 
  };
  
  const handleMouseOver = (e) => {
    e.currentTarget.style.translate = hoverStyle.translate;
    e.currentTarget.style.boxShadow = hoverStyle.boxShadow;
  }

  const handleMouseOut = (e) => {
    e.currentTarget.style.translate = "0 0 0";
    e.currentTarget.style.boxShadow = "none";
  }
  return (
    <Container maxWidth="lg" className="instrument-lessons-offered" sx={{ flexGrow: 1 }}>
      <div className="flex-col-center">
        <h2 className="heading" style={{ fontFamily: styles.fonts.HEADER_FONT }}>Instruments Lessons Offered</h2>
        <SearchIcon sx={{ position: "relative", translate: "-123px 2px", color: styles.colors.PRIMARY, opacity: .8 }}/>
        <input type="search"
          id="search-bar"
          onChange={(e) => handleSearchInput(e)}
          style={{
            fontSize: "16px",
            outline: "none",
            color: styles.colors.PRIMARY,
            padding: "5px 10px 5px 45px",
            marginTop: "-30px",
            marginBottom: "25px",
            width: "300px",
            border: `3px solid ${styles.colors.PRIMARY}`,
            borderRadius: "50px",
          }}
          placeholder="search instruments..."
        />
      </div>
      <div className="instrument-cards">
        {loading ?
        placeholders.map((_, index) => (
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
        instrumentList.map((instrument) => (
          <Card key={instrument.instrumentId} elevation={0} className="instrument-card" onMouseOver={handleMouseOver} onMouseOut={handleMouseOut} sx={{
          maxWidth: 345,
          border: `3px solid white`,
          borderRadius: "10px",
          transition: "translate .2s, box-shadow .25s",
          height: 'fit-content',
          display: !(instrument.name.toLowerCase().replace(' ','') in instrumentImages) && !seeAll ? 'none' : '',
          }}>
            {instrument.name.toLowerCase().replace(' ','') in instrumentImages ? (
              <CardMedia
              sx={{ height: 100, p:10, m: 2 }}
              image={instrumentImages[instrument.name.replace(' ','').toLowerCase()]}
              title={instrument.name}
              /> 
            ) : (
              null
            )}
            <CardContent sx={{ color: "white", backgroundColor: styles.colors.PRIMARY }}>
              <Typography gutterBottom variant="body1" component="div" sx={{ fontFamily: styles.fonts.HEADER_FONT }}>
                {instrument.name}
              </Typography>
              <Typography variant="caption" sx={{ opacity: .8 }}>
                {instrument.family}
              </Typography>
            </CardContent>
            <CardActions className="d-flex justify-content-center" sx={{ backgroundColor: styles.colors.PRIMARY, mt: -1, pb:3 }}>
              <HoverButton
                link={`/instrumental/instruments/${instrument.instrumentId}`}
                backgroundColor={styles.colors.SECONDARY}
                color={styles.colors.BLACK}
                fontSize="12px"
                padding="6px 20px"
              >
                Learn more
              </HoverButton>
            </CardActions>
          </Card>
        ))}
      </div>
      <div className="flex-col-center">
        { seeAll ? (
          <HoverButton backgroundColor={styles.colors.ACTION} 
            padding={'5px 25px'}
            onClick={() => setSeeAll(!seeAll)}>
            <Typography variant='body1' sx={{ fontSize: { xs: 13, md: 15 } }}>
              Show less
              <ExpandLessIcon sx={{ ml: .5, mr: -1, fontSize: { xs: 16, md: 25 } }}/>
            </Typography>
          </HoverButton>
        ) : (
          <HoverButton backgroundColor={styles.colors.ACTION} 
            padding={'5px 25px'}
            onClick={() => setSeeAll(!seeAll)}>
            <Typography variant='body1' sx={{ fontSize: { xs: 13, md: 15 } }}>
              Show more
              <ExpandMoreIcon sx={{ ml: .5, mr: -1, fontSize: { xs: 16, md: 25 } }}/>
            </Typography>
          </HoverButton>
        )}
      </div>
    </Container>
  );
};

export default InstrumentLessonsOffered;
