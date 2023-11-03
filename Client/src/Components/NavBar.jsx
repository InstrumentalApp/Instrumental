/* eslint-disable react/prop-types */
import styles from "../Styles/App";
import { useNavigate, Link } from "react-router-dom";
import Logo from "../Assets/Logos/InstrumentalLogo.svg";
import { useState } from "react";
import { styled } from "@mui/material/styles";
import AppBar from "@mui/material/AppBar";
import Box from "@mui/material/Box";
import Toolbar from "@mui/material/Toolbar";
import IconButton from "@mui/material/IconButton";
import Typography from "@mui/material/Typography";
import Menu from "@mui/material/Menu";
import MenuIcon from "@mui/icons-material/Menu";
import Container from "@mui/material/Container";
import Avatar from "@mui/material/Avatar";
import Button from "@mui/material/Button";
import Tooltip from "@mui/material/Tooltip";
import MenuItem from "@mui/material/MenuItem";
import useLocalStorage from '../Hooks/useLocalStorage';
import HoverButton from './HoverButton';

const navStyle = {
  display: 'flex',            // Use Flexbox
  alignItems: 'center',      // Vertically center items
  backgroundColor: styles.colors.SECONDARY,  // Background color
  width: "100%",
  height: styles.spacing.HEADER_HEIGHT,
  color: styles.colors.BLACK,
};

const NavButton = styled(Button)(() => ({
  textTransform: "none",
  fontSize: 16,
  paddingTop: 12,
  marginLeft: 15,
  color: styles.colors.BLACK,
  backgroundColor: styles.colors.SECONDARY,
  height: styles.spacing.HEADER_HEIGHT,
  borderRadius: 0,
  borderBottom: `5px solid ${styles.colors.SECONDARY}`,
  '&:hover': {
    backgroundColor: styles.colors.SECONDARY,
    borderBottom: `5px solid ${styles.colors.PRIMARY}`
  },
}));

const pages = [
  ['Lessons', '/instrumental/instruments'], 
  // ['Rentals', '/instrumental/rentals'], 
  ['How it works', '/instrumental/how-it-works'], 
  ['Teach with us', '/instrumental/teach-with-us'], 
  ['Contact', '/instrumental/contact']];
const settings = [
  ['Profile', '/instrumental/profile'], 
  ['Account', '/instrumental/account'], 
  ['Dashboard', '/instrumental/dashboard']
];

const NavBar = (props) => {
  const [anchorNav, setAnchorNav] = useState(null);
  const [anchorUser, setAnchorUser] = useState(null);
  const navigate = useNavigate();
  const [credentials, setCredentials] = useLocalStorage("credentials", {});

  const handleOpenNavMenu = (event) => {
    setAnchorNav(event.currentTarget);
  };
  const handleOpenUserMenu = (event) => {
    setAnchorUser(event.currentTarget);
  };

  const handleCloseNavMenu = () => {
    setAnchorNav(null);
  };

  const handleCloseUserMenu = () => {
    setAnchorUser(null);
  };

  const handleLogout = () => {
    setCredentials({});
    navigate("/");
  }

  return (
    <AppBar position="sticky" style={navStyle} elevation={props.scrollPosition == 0 ? 0 : 3}>
      <Container maxWidth="lg">
        <Toolbar disableGutters sx={{ mt: {xs: .3, md: 0} }}>
          <Typography
            variant="h6"
            noWrap
            component="a"
            onClick={() => navigate("/")}
            sx={{
              mr: 2,
              display: { xs: "none", md: "flex" },
              fontWeight: 700,
              color: 'inherit',
              textDecoration: 'none',
              alignItems: "center",
              fontFamily: styles.fonts.LOGO_FONT,
              gap: 1.2,
              "&:hover": {
                cursor: "pointer",
              },
            }}
          >
            <img src={Logo} alt="Logo" height={styles.spacing.HEADER_HEIGHT - 40} />
            instrumental
          </Typography>

          <Box sx={{ flexGrow: 1, display: { xs: "flex", md: "none" } }}>
            <IconButton
              size="large"
              aria-controls="menu-appbar"
              aria-haspopup="true"
              onClick={handleOpenNavMenu}
              color="inherit"
            >
              <MenuIcon />
            </IconButton>
            <Menu
              id="menu-appbar"
              anchorEl={anchorNav}
              anchorOrigin={{
                vertical: "top",
                horizontal: "left",
              }}
              keepMounted
              transformOrigin={{
                vertical: "top",
                horizontal: "left",
              }}
              open={Boolean(anchorNav)}
              onClose={handleCloseNavMenu}
              sx={{
                display: { xs: 'block', md: 'none', "& .MuiMenu-paper":
                { backgroundColor: styles.colors.SECONDARY }
              },
              mt: 5.5,
              }}
            >
              {pages.map((page) => (
                <MenuItem key={page}
                sx = {{ backgroundColor: styles.colors.SECONDARY }}
                onClick={() => {
                  handleCloseNavMenu();
                  navigate(page[1]);
                  }}>
                  <Typography textAlign="center">{page[0]}</Typography>
                </MenuItem>
              ))}
            </Menu>
          </Box>
          <IconButton
            sx={{ display: { xs: "flex", md: "none" }, mr: 1 }}
          ></IconButton>
          <Typography
            variant="h6"
            noWrap
            onClick={() => navigate("/")}
            component="a"
            sx={{
              mr: 2,
              display: { xs: "flex", md: "none" },
              flexGrow: 1,
              fontWeight: 700,
              color: 'inherit',
              textDecoration: 'none',
              alignItems: "center",
              fontFamily: styles.fonts.LOGO_FONT,
              gap: 1.2,
              "&:hover": {
                cursor: "pointer",
              },
            }}
          >
            <img src={Logo} alt="Logo" height={styles.spacing.HEADER_HEIGHT - 40} />
            instrumental
          </Typography>
          <Box sx={{ flexGrow: 1, display: { xs: "none", md: "flex" } }}>
            {pages.map((page) => (
              <NavButton
                key={page}
                onClick={() => {
                  handleCloseNavMenu();
                  navigate(page[1]);
                }}
                sx={{ color: styles.colors.PRIMARY, display: 'block', fontSize: 16, fontWeight: 700 }}
              >
                <nobr>{page[0]}</nobr>
              </NavButton>
            ))}
          </Box>
          {credentials && Object.keys(credentials).length > 0 ? (
            <Box sx={{ flexGrow: 0 }}>
              <Tooltip title="Open settings">
                <IconButton onClick={handleOpenUserMenu} sx={{ p: 0 }}>
                  <Avatar alt="User avatar" src="" sx={{ border: `3px solid ${styles.colors.PRIMARY}` }}/>
                </IconButton>
              </Tooltip>
              <Menu
                id="menu-appbar"
                anchorEl={anchorUser}
                anchorOrigin={{
                  vertical: "top",
                  horizontal: "right",
                }}
                keepMounted
                transformOrigin={{
                  vertical: "top",
                  horizontal: "right",
                }}
                open={Boolean(anchorUser)}
                onClose={handleCloseUserMenu}
                sx={{
                  display: { 
                    "& .MuiMenu-paper": { backgroundColor: styles.colors.SECONDARY }
                  },
                  mt: 5.5,
                }}
              >
                {settings.map((setting) => (
                  <MenuItem key={setting} onClick={handleCloseUserMenu}>
                    <Link to={setting[1]} style={{ textDecoration: 'none', color: styles.colors.BLACK }}>
                      <Typography textAlign="center" >{setting[0]}</Typography>
                    </Link>
                  </MenuItem>

                ))}
                <MenuItem key={"logout"} onClick={handleCloseUserMenu}>
                  <Typography onClick={handleLogout} textAlign="center">Logout</Typography>
                </MenuItem>
              </Menu>
            </Box>
          ) : (
            <Box sx={{ flexGrow: 0 }}>
              {credentials && Object.keys(credentials).length > 0 ? (
                <Button
                  onClick={() => {
                    handleCloseNavMenu();
                    handleLogout();
                  }}
                  sx={{
                    ml: 3,
                    px: { sm: 1.5 },
                    fontSize: { xs: 11, sm: 13 },
                    color: "white",
                    display: "block",
                    backgroundColor: styles.colors.PRIMARY,
                    border: `2px solid ${styles.colors.PRIMARY}`,
                    "&:hover": {
                      backgroundColor: styles.colors.SECONDARY,
                      color: styles.colors.PRIMARY,
                    },
                  }}
                >
                  <nobr>Sign Out</nobr>
                </Button>
              ) : window.location.pathname == "/instrumental/sign-in" || window.location.pathname == "/instrumental/register" ? (
                <></>
              ) : (
                <HoverButton
                  link="/instrumental/sign-in"
                  onClick={ () => {
                    handleCloseNavMenu();
                  }}
                  padding="5px 15px"
                  margin="0 0 8px 0"
                  fontSize="14px"
                >
                  <nobr>Sign in</nobr>
                </HoverButton>
              )}
            </Box>
          )}
        </Toolbar>
      </Container>
    </AppBar>
  );
};
export default NavBar;
