import { Container, Grid, Typography } from "@mui/material";
import React from 'react';
import styles from "../Styles/App";

const HowItWorks = () => {
  const content = [
    {
      title: "Join, Learn, Play - Find Your Perfect Tune!",
      description: "Students, your musical journey begins here. Join Instrumental and embark on a melodious adventure. Search for lessons by your desired instrument, and explore a diverse selection of teachers. Discover the right teacher for you, learn at your own pace, and ignite your passion for music.",
    },
    {
      title: "Teachers, Share Your Expertise!",
      description: "Calling all music mentors, we've got you covered. Offer lessons in a variety of instruments and list your availability for eager students to find. Instrumental provides a seamless platform to showcase your talents and connect with enthusiastic learners. Share your knowledge and inspire the next generation of musicians.",
    },
    {
      title: "Start Your Musical Odyssey with Ease",
      description: "Instrumental simplifies the path to your musical aspirations. It's the perfect platform to kickstart your music journey and find opportunities that align with your schedule and preferences. Whether you're a student looking to learn or a teacher ready to share your skills, Instrumental makes it easy and simple. Your musical future awaits!",
    }
  ]

  return (
    <Container maxWidth="xl">
      <Grid container spacing={4}>
        <Grid item xs={12} className="d-flex">
          <div>
            <Typography variant="h4" component="h2" mt={5} mb={2} maxWidth={1000} sx={{
              fontFamily: styles.fonts.HEADER_FONT,
              color: styles.colors.PRIMARY,
              fontWeight: 'bold',
              letterSpacing: 2,
            }}
            >
              {"How It Works"}
            </Typography>
          </div>
        </Grid>
        {content.map((section, index) => (
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
              <Typography variant="body1" width="100%">
                {section.description}
              </Typography>
            </Grid>
            {/* <Grid item xs={4}> Image is on the right (4 columns) 
              <img src={section.image} alt={section.title} style={{ maxWidth: '100%' }} />
            </Grid> */}
          </Grid>
        ))}
      </Grid>
    </Container>
  )
}

export default HowItWorks;
