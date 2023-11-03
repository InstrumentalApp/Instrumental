import { useState } from 'react';
import Grid from '@mui/material/Unstable_Grid2';
import Typography from '@mui/material/Typography';
import Container from '@mui/material/Container';
import Box from '@mui/material/Box';
import styles from '../Styles/App';
import AnimatedPic from "../Assets/strum.gif"
import StaticPic from "../Assets/strum_static.png"
import HoverButton from './HoverButton';

const AboutUs = () => {
  const [hovered, setHovered] = useState(false);

  return (
    <Container maxWidth="lg">
      <Grid container spacing={4}>
        <Grid item="true" xs={12} mt={6} className='d-flex justify-content-center' sx={{ 
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
        <Grid container spacing={2}>
          {aboutSections.map((section, index) => (
            <Grid key={index} item="true" container xs={12} md={2}>
              <img src={StaticPic} alt={section.title} style={{ maxWidth: '100%' }} />
              <Grid item="true" xs={4}>
              </Grid>
            </Grid>
          ))}
        </Grid>
        {aboutSections.map((section, index) => (
          <Grid item="true" container xs={12} key={index}>
            <Grid item="true" xs={8}> {/* Text is on the left (8 columns) */}
              <Typography variant="h5" component="h3" mb={1} sx={{ 
                fontFamily: styles.fonts.HEADER_FONT,
                color: styles.colors.PRIMARY,
                fontWeight: 'bold',
                letterSpacing: 2,
                }}
              >
                {section.title}
              </Typography>
              <Typography variant="body1" width="70%" maxWidth={600}>
                {section.description}
              </Typography>
            </Grid>
            <Grid item="true" xs={4}> {/* Image is on the right (4 columns) */}
              <img src={StaticPic} alt={section.title} style={{ maxWidth: '100%' }} />
            </Grid>
          </Grid>
        ))}
      </Grid>
    </Container>
  );
};

const aboutSections = [
  {
    title: 'Connecting the World Through Music',
    description: 'Instrumental offers online lessons, breaking geographical barriers. Connect with teachers worldwide and explore diverse musical styles.',
    image: StaticPic ,
  },
  {
    title: "The Teacher's Corner",
    description: 'Teachers create personalized profiles, highlighting their credentials, specialties, and teaching styles. Easily manage lesson schedules, prices, and locations.',
    image: StaticPic,
  },
  {
    title: "The Student's Oasis",
    description: "Students discover the perfect teacher through our intuitive search system. Whether you're a beginner or a jazz enthusiast, Instrumental caters to all. Explore teacher profiles, read reviews, and make informed decisions.",
    image: StaticPic,
  },
  {
    title: 'Seamless Booking & Communication',
    description: 'Our user-friendly booking system simplifies scheduling. Find available slots and book lessons with ease. Integrated messaging ensures clear communication.',
    image: StaticPic ,
  },
  {
    title: 'Secure Payment & Reviews',
    description: 'Trust is essential. We provide a secure payment gateway, with reviews and ratings after lessons for transparency.',
    image: StaticPic,
  },
  {
    title: 'Educational Resources',
    description: 'Explore our rich collection of educational resources, from articles to video tutorials, enhancing your learning journey.',
    image: StaticPic ,
  },
  // {
  //   title: 'Instrumental Community',
  //   description: "Instrumental is more than a platform; it's a musical community where students and teachers share their passion for learning and teaching. With a user-friendly interface and secure payment system, we're your ultimate destination for musical growth. Join us today and create a harmonious world of music.",
  //   image: StaticPic ,
  // },
];

export default AboutUs;