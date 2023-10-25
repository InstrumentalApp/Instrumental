import style from "../Styles/App";
import { useNavigate } from 'react-router-dom';
import Logo from "../Assets/Images/Logos/InstrumentalLogoWhite.svg"
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import Paper from '@mui/material/Paper';
import Container from '@mui/material/Container';
import Divider from '@mui/material/Divider';
import Link from '@mui/material/Link';

const Footer = () => {
  const links = {
    "About":{
      "Lessons": "/instruments",
      // "Rentals": "/rentals",
      "How it works": "/how-it-works",
      "Teach with us": "/teach-with-us",
      "Contact": "/contact",
    },
    "Legal":{
      "Terms of service": "/terms-of-service",
      "Privacy policy": "/privacy-policy",
    },
    "Account":{
      "Sign in": "/sign-in",
      "Register": "/register"
    },
  };

  const navigate = useNavigate();

  return (
    <Paper 
    sx={{ marginTop: 'calc(10% + 60px)', p: 2, pt: 5,
    width: '100%',
    minWidth: "min-content",
    height: "min-content",
    minHeight: style.spacing.HEADER_HEIGHT * 3,
    position: 'static',
    bottom: 0,
    backgroundColor: style.colors.PRIMARY,
    color: "white",
    display: "flex",
    flexDirection: "column",
    justifyContent: "end"
    }} component="footer" square>
      <Container maxWidth="xl" 
      sx={{ 
        display: "flex", 
        flexDirection: { xs: "column", md: "row"},
        justifyContent: "space-between",
      }}>
        <Box mb={4}
          sx={{
            flexGrow: 1,
            display: "flex",
            flexDirection: "column",
            justifyContent: "start",
          }}
        >
          <Typography
            variant="h4"
            noWrap
            onClick={() => navigate('/')}
            component="a"
            sx={{
              mb: 2,
              display: 'flex',
              fontWeight: 700,
              letterSpacing: '.1rem',
              color: 'inherit',
              textDecoration: 'none',
              alignItems: "center",
              fontFamily: 'Noto Serif',
              gap: 1.5,
              '&:hover': {
                cursor: "pointer",
              }
            }}
          >
            <img src={Logo} alt="Logo" width={60} />
            instrumental
          </Typography>
          <Typography variant="body1" 
          sx={{ width: {xs: 300, sm:450, md:300},
            lineHeight: 1.7 }}>
            Our mission is to empower teachers and 
            students alike as they each navigate their 
            individual journeys through music.
          </Typography>
        </Box>
        <Box
          sx={{
            flexGrow: 1,
            justifyContent: {xs:"start", sm:"space-between", md: "end"},
            display: "flex",
            flexWrap: {  xs: "wrap", md: "nowrap"},
            gap: { xs:4, md:8 },
            px: { md:3 }
          }}
        >
          {Object.entries(links).map(([heading, subheadings]) => 
          <div key={heading} 
          style={{ display: "flex", 
          flexDirection: "column",
          gap: 1
          }}>
            <Typography noWrap variant="subtitle1" mb={1}
            sx={{ opacity:.7, letterSpacing:2, 
            fontWeight: 600 }}>
              {heading}
            </Typography>
            {Object.entries(subheadings).map(([subheading, link]) => 
              <Typography  key={subheading} noWrap variant="subtitle1" sx={{ opacity:1 }}>
                <Link href={link} noWrap color="inherit" underline="hover">
                  {subheading}
                </Link>
              </Typography>
            )}
          </div>
          )}
        </Box>

      </Container>
      <Divider variant="middle" sx={{ backgroundColor: "white", height: 2, opacity: .7, my:2 }}/>
      <Container maxWidth="xl" 
      sx={{ display: "flex",
        flexDirection: { xs: "column", md: "row"},
        alignItems: "center",
        justifyContent: "space-between",
        gap: 1
      }}>
        <Typography variant="subtitle1" noWrap >
          © 2023 Instrumental, Inc. All rights reserved
        </Typography>
        <Typography variant="subtitle1" noWrap >
          (012) 345-6789 &nbsp; | &nbsp; team@instrumental.com
        </Typography>
      </Container>
    </Paper>
  );
}

export default Footer;
