import { Container, Grid, Typography } from "@mui/material";
import React from 'react';
import styles from "../Styles/App";
import HoverButton from "./HoverButton";

const TeachWithUs = () => {

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
              {"Teach With Us"}
            </Typography>
          </div>
        </Grid>
        <Grid item>
          <Typography variant="body1" width="100%">
            {"Join our vibrant music community and share your passion for teaching! To get started, simply submit a form with your experience, availability, and the lessons you offer. Instrumental makes it easy for you to connect with students seeking your expertise. Let's make beautiful music together – submit your details and open the door to new teaching opportunities!"}
          </Typography>
        </Grid>
        <Grid item>
          <HoverButton link="instrumental/teacher-signup" margin="2rem 0 0 0">Get started!</HoverButton>
        </Grid>
      </Grid>
    </Container>
  )
}

export default TeachWithUs;
