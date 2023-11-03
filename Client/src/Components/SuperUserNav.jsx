import styles from "../Styles/App";
import { useNavigate } from "react-router-dom";
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
import Button from "@mui/material/Button";
import MenuItem from "@mui/material/MenuItem";
import useLocalStorage from '../Hooks/useLocalStorage';

const navStyle = {
  display: 'flex',            // Use Flexbox
  alignItems: 'center',      // Vertically center items
  backgroundColor: styles.colors.PRIMARY,  // Background color
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
  backgroundColor: styles.colors.PRIMARY,
  height: styles.spacing.HEADER_HEIGHT,
  borderRadius: 0,
  borderBottom: `5px solid ${styles.colors.PRIMARY}`,
  '&:hover': {
    backgroundColor: styles.colors.PRIMARY,
    borderBottom: `5px solid ${styles.colors.SECONDARY}`
  },
}));

const pages = [
  ["SuperUser Dashboard", "/admin/dashboard"],
  ["Add A Teacher", "/admin/teachers/create"],
  ["Edit Instrument", "/admin/instruments/image-upload"],
  ["Deactivate Users", "/admin/users/deactivate"],
  ["Edit Lessons", "/admin/lessons/edit"],
  ["Revoke Tokens", "/admin/users/tokens/revoke"]
];

const SuperUserNav = () => {
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
    <AppBar position="sticky" style={navStyle}>
      <Container maxWidth="xl">
        <Toolbar
          disableGutters
          // sx={{ mt: { xs: 0.7, md: 0 } }}
        >
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
          </Box>
          <Box sx={{ flexGrow: 1, display: { xs: "none", md: "flex" } }}>
            {pages.map((page) => (
              <NavButton
                key={page}
                onClick={() => {
                  handleCloseNavMenu();
                  navigate(page[1]);
                }}
                sx={{ color: "white", display: "block" }}
              >
                <nobr>{page[0]}</nobr>
              </NavButton>
            ))}
          </Box>
        </Toolbar>
      </Container>
    </AppBar>
  );
};
export default SuperUserNav;

