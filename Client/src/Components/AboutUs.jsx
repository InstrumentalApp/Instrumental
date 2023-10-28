import { useState } from 'react';
import List from '@mui/material/List';
import Grid from '@mui/material/Grid';
import ListItem from '@mui/material/ListItem';
import ListItemText from '@mui/material/ListItemText';
import Typography from '@mui/material/Typography';
import Container from '@mui/material/Container';
import styles from '../Styles/App';
import AnimatedPic from "../Assets/strum.gif"
import StaticPic from "../Assets/strum_static.png"
import HoverButton from './HoverButton';

const AboutUs = () => {
  const [hovered, setHovered] = useState(false);

  return (
    <Container maxWidth="xl">
      <Grid container spacing={4}>
        <Grid item xs={12} className='d-flex '>
          <div>
            <Typography variant="h4" component="h2" mt={5} mb={2} maxWidth={500} sx={{
              fontFamily: styles.fonts.HEADER_FONT,
              color: styles.colors.PRIMARY,
              fontWeight: 'bold',
              letterSpacing: 2,
              }}
            >
              {"Welcome to Instrumental – Your Music Education Hub!"}
            </Typography>
            <Typography variant="body1" width="80%">
              Are you an aspiring musician or a passionate music teacher? Instrumental is your one-stop destination, bridging the gap between music teachers and eager learners, making music education more accessible and enjoyable.
            </Typography>
            {/* <HoverButton link='/instruments' text="Browse Instruments"/> */}
            <HoverButton link='/instruments' margin="2rem 0 0 0">Explore Lessons</HoverButton>
          </div>
          <img src={hovered ? AnimatedPic : StaticPic} alt="guitar-animation" style={{ borderRadius: "7%", marginTop: "3rem"}} width={400} height={400}
          onMouseOver={() => {setHovered(true)}} onMouseOut={() => {setHovered(false)}}/>
        </Grid>
        {aboutSections.map((section, index) => (
          <Grid item container xs={12} key={index}>
            <Grid item xs={8}> {/* Text is on the left (8 columns) */}
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
            <Grid item xs={4}> {/* Image is on the right (4 columns) */}
              <img src={section.image} alt={section.title} style={{ maxWidth: '100%' }} />
            </Grid>
          </Grid>
        ))}
      </Grid>
    </Container>
  );
};

const aboutSections = [
  {
    title: 'Empowering Music Education',
    description: 'We connect students with skilled teachers, fostering a harmonious community of learning. Teachers can showcase their expertise, while students can find their ideal instructors.',
    image: '/path/to/empowering-music-education-image.jpg',
  },
  {
    title: "The Teacher's Corner",
    description: 'Teachers create personalized profiles, highlighting their credentials, specialties, and teaching styles. Easily manage lesson schedules, prices, and locations.',
    image: '/path/to/teachers-corner-image.jpg',
  },
  {
    title: "The Student's Oasis",
    description: "Students discover the perfect teacher through our intuitive search system. Whether you're a beginner or a jazz enthusiast, Instrumental caters to all. Explore teacher profiles, read reviews, and make informed decisions.",
    image: '/path/to/students-oasis-image.jpg',
  },
  {
    title: 'Seamless Booking & Communication',
    description: 'Our user-friendly booking system simplifies scheduling. Find available slots and book lessons with ease. Integrated messaging ensures clear communication.',
    image: '/path/to/seamless-booking-image.jpg',
  },
  {
    title: 'Secure Payment & Reviews',
    description: 'Trust is essential. We provide a secure payment gateway, with reviews and ratings after lessons for transparency.',
    image: '/path/to/secure-payment-image.jpg',
  },
  {
    title: 'Educational Resources',
    description: 'Explore our rich collection of educational resources, from articles to video tutorials, enhancing your learning journey.',
    image: '/path/to/educational-resources-image.jpg',
  },
  {
    title: 'Connecting the World Through Music',
    description: 'Instrumental offers online lessons, breaking geographical barriers. Connect with teachers worldwide and explore diverse musical styles.',
    image: '/path/to/connecting-world-image.jpg',
  },
  {
    title: 'Instrumental Community',
    description: "Instrumental is more than a platform; it's a musical community where students and teachers share their passion for learning and teaching. With a user-friendly interface and secure payment system, we're your ultimate destination for musical growth. Join us today and create a harmonious world of music.",
    image: '/path/to/instrumental-community-image.jpg',
  },
];

export default AboutUs;