import { useState, useEffect } from 'react';
import Grid from '@mui/material/Unstable_Grid2';
import Typography from '@mui/material/Typography';
import Container from '@mui/material/Container';
import Box from '@mui/material/Box';
import styles from '../Styles/App';
import AnimatedPic from "../Assets/strum.gif"
import StaticPic from "../Assets/strum_static.png"
import Connection from "../Assets/About-Us/Connection.jpg"
import Teachers from "../Assets/About-Us/Teachers.jpg"
import Students from "../Assets/About-Us/Students.jpg"
import Convenience from "../Assets/About-Us/Convenience.jpg"
import Security from "../Assets/About-Us/Security.jpg"
import Resources from "../Assets/About-Us/Resources.jpg"
import HoverButton from './HoverButton';
import PeopleIcon from '@mui/icons-material/People';
import MenuBookIcon from '@mui/icons-material/MenuBook';
import CreateIcon from '@mui/icons-material/Create';
import ScheduleIcon from '@mui/icons-material/Schedule';
import ShieldIcon from '@mui/icons-material/Shield';
import SettingsSuggestIcon from '@mui/icons-material/SettingsSuggest';

const AboutUs = () => {
  const [hovered, setHovered] = useState(false);
  const [selectedSection, setSelectedSection] = useState("Connection");

  useEffect(() => {
    document.getElementById("Connection").style.translate = hoverStyle.translate;
  }, []);

  // This will create the effect of highlighting current card
  const hoverStyle = {
    translate: "-5px -5px 0",
    border: `3px solid ${styles.colors.BLACK}`,
    boxShadow: `5px 5px 0 ${styles.colors.BLACK}`, 
  };
  
  const handleMouseOver = (e) => {
    if(selectedSection === e.currentTarget.children[1].innerHTML) return;
    e.currentTarget.style.translate = hoverStyle.translate;
    e.currentTarget.style.border = hoverStyle.border;
    e.currentTarget.style.boxShadow = hoverStyle.boxShadow;
  }
  
  const handleMouseOut = (e) => {
    if(selectedSection === e.currentTarget.children[1].innerHTML) return;
    e.currentTarget.style.translate = "0 0 0";
    e.currentTarget.style.border = "3px solid white";
    e.currentTarget.style.boxShadow = "none";
  }

  const resetHover = (tagline) => {
    setSelectedSection(tagline);
    let sections = document.getElementsByClassName('about-section');
    for(let i = 0; i < sections.length; i++) {
      if(sections[i].children[1].innerHTML === tagline) continue;
      sections[i].style.translate = "0 0 0";
      sections[i].style.border = "3px solid white";
      sections[i].style.boxShadow = "none";
    }
  }

  return (
    <Container maxWidth="lg" flex={true} sx={{ flexGrow: 1 }}>
      <Grid container={true} spacing={9} sx={{ display: 'flex', flexDirection: 'column', alignItems: 'center' }}>
        <Grid xs={12} mt={6} sx={{ display: 'flex', justifyContent: 'center',
          flexDirection: { xs: "column-reverse", sm: "row" },
          alignItems: { xs:"center", sm:"start" }, 
          }}
        >
          <div>
            <Typography variant="h1" component="h2" mb={2} width={{ xs: "100%" , sm: "90%" }} sx={{
              fontFamily: styles.fonts.HEADER_FONT,
              color: styles.colors.PRIMARY,
              fontWeight: 'bold',
              letterSpacing: { xs: 1, sm: 2 },
              fontSize: { xs: 26, md: 37 },
              }}
            >
              Affordable music education with top-rated, accessible instructors
            </Typography>
            <Typography variant="h6" width={{ xs: "100%" , sm: "82%" }} sx={{ 
              my: { sm: 0, md: 3 }, 
              fontSize: { xs: 15, md: 18, lg: 20 },
              }}>
              We bridge the gap between music teachers and eager learners, making music education more accessible and enjoyable.
            </Typography>
            <HoverButton link='/instrumental/instruments' margin="2rem 0 0 0">
              <Typography variant='body1' sx={{ fontSize: { xs: 13, md: 16 } }}>Explore lessons</Typography>
            </HoverButton>
          </div>
          <Box sx={{ 
              borderRadius: "7%",
              width: {xs: 0, sm: 200, md: 400 },
              height: {xs: 0, sm: 200, md: 400 },
            }} >
            <img src={hovered ? AnimatedPic : StaticPic} alt="guitar-animation" style={{ 
              borderRadius: "7%",
              width: "inherit",
              height: "inherit",
              objectFit: "cover",
            }} 
            onMouseOver={() => {setHovered(true)}} onMouseOut={() => {setHovered(false)}}/>
          </Box>
        </Grid>
        <Grid container={true} xs={12} column={1} sx={{ border: '3px solid white', 
          borderRadius: "30px",
          backgroundColor: "#ffeddb",
          my: 2,
        }}>
          <Grid container={true} spacing={1} xs={12} sx={{ display: 'flex',
            justifyContent: 'center',
            width: {lg: '100%', xs: '80%'},
            gap: 3,
            }}
          >
            {aboutSections.map((section, index) => (
              <Box key={index} container={true} xs={12} md={2} columns={1} className="about-section" id={section.tagline}
                onClick={() => {
                  resetHover(section.tagline);
                }}
                onMouseOver={handleMouseOver} onMouseOut={handleMouseOut}
                sx={{ backgroundColor: styles.colors.SECONDARY,
                  display: 'flex',
                  py: "30px",
                  border: selectedSection === section.tagline ? `3px solid ${styles.colors.BLACK}` : '3px solid white',
                  boxShadow: selectedSection === section.tagline ? `5px 5px 0px ${styles.colors.BLACK}` :'',
                  translate: selectedSection === section.tagline ? `5px 5px 0` : '0 0 0',
                  flexDirection: 'column',
                  justifyContent: 'center',
                  alignItems: 'center',
                  width: 170,
                  borderRadius: 5,
                  opacity:  0.9,
                  transition: "translate .2s, box-shadow .25s, border .3s",
                }}>
                  { section.tagline === "Connection" ?
                    <PeopleIcon sx={{ fontSize: 50 }} /> :
                    section.tagline === "Teachers" ?
                    <MenuBookIcon sx={{ fontSize: 50 }} /> :
                    section.tagline === "Students" ?
                    <CreateIcon sx={{ fontSize: 50 }} /> :
                    section.tagline === "Convenience" ?
                    <ScheduleIcon sx={{ fontSize: 50 }} /> :
                    section.tagline === "Security" ?
                    <ShieldIcon sx={{ fontSize: 50 }} /> :
                    section.tagline === "Resources" ?
                    <SettingsSuggestIcon sx={{ fontSize: 50 }} />
                    : null
                  }
                  <Typography>{section.tagline}</Typography>
              </Box>
            ))}
          </Grid>
          <Grid container={true} xs={12}>
            {aboutSections.map((section, index) => (
              <Grid container={true} xs={12} key={index} sx={{ display: selectedSection != section.tagline ? 'none' : '' }}>
                <Grid xs={7}> {/* Image is on the right (4 columns) */}
                  <img src={section.image} alt={section.title} style={{ maxWidth: '100%', borderRadius: "7%" }} />
                </Grid>
                <Grid xs={5}> {/* Text is on the left (8 columns) */}
                  <Typography variant="h4" component="h3" mb={1} sx={{
                    fontFamily: styles.fonts.HEADER_FONT,
                    color: styles.colors.BLACK,
                    fontWeight: 'bold',
                    letterSpacing: 2,
                    }}
                  >
                    {section.title}
                  </Typography>
                  <Typography variant="h6" width="100%" maxWidth={600} mt={4} sx={{ opacity: .7 }}>
                    {section.description}
                  </Typography>
                </Grid>
              </Grid>
            ))}
          </Grid>
        </Grid>
      </Grid>
    </Container>
  );
};

const aboutSections = [
  {
    tagline: "Connection",
    title: "Connecting the World Through Music",
    description: "Instrumental offers online lessons, breaking geographical barriers. Connect with teachers worldwide and explore diverse musical styles.",
    image: Connection ,
  },
  {
    tagline: "Teachers",
    title: "The Teacher's Corner",
    description: "Teachers create personalized profiles, highlighting their credentials, specialties, and teaching styles. Easily manage lesson schedules, prices, and locations.",
    image: Teachers,
  },
  {
    tagline: "Students",
    title: "The Student's Oasis",
    description: "Students discover the perfect teacher through our intuitive search system. Whether you're a beginner or a jazz enthusiast, Instrumental caters to all. Explore teacher profiles, read reviews, and make informed decisions.",
    image: Students,
  },
  {
    tagline: "Convenience",
    title: "Seamless Booking & Communication",
    description: "Our user-friendly booking system simplifies scheduling. Find available slots and book lessons with ease. Integrated messaging ensures clear communication.",
    image: Convenience,
  },
  {
    tagline: "Security",
    title: "Secure Payment & Reviews",
    description: "Trust is essential. We provide a secure payment gateway, with reviews and ratings after lessons for transparency.",
    image: Security,
  },
  {
    tagline: "Resources",
    title: "Educational Resources",
    description: "Explore our rich collection of educational resources, from articles to video tutorials, enhancing your learning journey.",
    image: Resources,
  },
  // {
  //   tagline: "Instrumental Community",
  //   title: "Instrumental Community",
  //   description: "Instrumental is more than a platform; it"s a musical community where students and teachers share their passion for learning and teaching. With a user-friendly interface and secure payment system, we"re your ultimate destination for musical growth. Join us today and create a harmonious world of music.",
  //   image: StaticPic ,
  // },
];

export default AboutUs;