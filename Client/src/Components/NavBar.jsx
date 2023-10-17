import style from "../Styles/App";
import { useNavigate } from 'react-router-dom';
import Logo from "../Assets/Images/Logos/InstrumentalLogo.svg"
import { useState } from 'react'
import { styled } from '@mui/material/styles';
import AppBar from '@mui/material/AppBar';
import Box from '@mui/material/Box';
import Toolbar from '@mui/material/Toolbar';
import IconButton from '@mui/material/IconButton';
import Typography from '@mui/material/Typography';
import Menu from '@mui/material/Menu';
import MenuIcon from '@mui/icons-material/Menu';
import Container from '@mui/material/Container';
import Avatar from '@mui/material/Avatar';
import Button from '@mui/material/Button';
import Tooltip from '@mui/material/Tooltip';
import MenuItem from '@mui/material/MenuItem';

const navStyle = {
  display: 'flex',            // Use Flexbox
  alignItems: 'center',      // Vertically center items
  backgroundColor: style.colors.SECONDARY,  // Background color
  width: "100%",
  height: style.spacing.HEADER_HEIGHT,
  color: style.colors.BLACK,
};

const NavButton = styled(Button)(() => ({
  textTransform: "none",
  fontSize: 16,
  paddingTop: 12,
  marginLeft: 15,
  color: style.colors.BLACK,
  backgroundColor: style.colors.SECONDARY,
  height: style.spacing.HEADER_HEIGHT,
  borderRadius: 0,
  borderBottom: `5px solid ${style.colors.SECONDARY}`,
  '&:hover': {
    backgroundColor: style.colors.SECONDARY,
    borderBottom: `5px solid ${style.colors.PRIMARY}`
  },
}));

const pages = [
  ['Lessons', '/instruments'], 
  ['Rentals', '/rentals'], 
  ['How it Works', '/how-it-works'], 
  ['Teach with Us', '/teach-with-us'], 
  ['Contact', '/contact']];
const settings = ['Profile', 'Account', 'Dashboard', 'Logout'];

const NavBar = () => {
  const [anchorElNav, setAnchorElNav] = useState(null);
  const [anchorElUser, setAnchorElUser] = useState(null);
  const navigate = useNavigate();
  const [auth, setAuth] = useState(false);

  const handleOpenNavMenu = (event) => {
    setAnchorElNav(event.currentTarget);
  };
  const handleOpenUserMenu = (event) => {
    setAnchorElUser(event.currentTarget);
  };

  const handleCloseNavMenu = () => {
    setAnchorElNav(null);
  };

  const handleCloseUserMenu = () => {
    setAnchorElUser(null);
  };

  return (
    <AppBar position="static" style={navStyle}>
      <Container maxWidth="xl">
        <Toolbar disableGutters sx={{ mt: {xs: .7, md: 0} }}>
          <Typography
            variant="h6"
            noWrap
            component="a"
            onClick={() => navigate('/')}
            sx={{
              mr: 2,
              display: { xs: 'none', md: 'flex' },
              fontWeight: 700,
              letterSpacing: '.2rem',
              color: 'inherit',
              textDecoration: 'none',
              alignItems: "center",
              fontFamily: 'Noto Serif',
              gap: 1.2,
              '&:hover': {
                cursor: "pointer",
              }
            }}
          >
            <img src={Logo} alt="Logo" height={style.spacing.HEADER_HEIGHT - 40} />
            instrumental
          </Typography>

          <Box sx={{ flexGrow: 1, display: { xs: 'flex', md: 'none'} }}>
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
              anchorEl={anchorElNav}
              anchorElOrigin={{
                vertical: 'top',
                horizontal: 'left',
              }}
              keepMounted
              transformOrigin={{
                vertical: 'top',
                horizontal: 'left',
              }}
              open={Boolean(anchorElNav)}
              onClose={handleCloseNavMenu}
              sx={{
                display: { xs: 'block', md: 'none', "& .MuiMenu-paper": 
                { backgroundColor: style.colors.SECONDARY }
              },
              }}
            >
              {pages.map((page) => (
                <MenuItem key={page} 
                sx = {{ backgroundColor: style.colors.SECONDARY }}
                onClick={() => {
                  handleCloseNavMenu(); 
                  navigate(page[1]);
                  }}>
                  <Typography textAlign="center">{page[0]}</Typography>
                </MenuItem>
              ))}
            </Menu>
          </Box>
          <IconButton sx={{ display: { xs: 'flex', md: 'none' }, mr: 1 }}>
          </IconButton> 
          <Typography
            variant="h6"
            noWrap
            onClick={() => navigate('/')}
            component="a"
            sx={{
              mr: 2,
              display: { xs: 'flex', md: 'none' },
              flexGrow: 1,
              fontWeight: 700,
              letterSpacing: '.1rem',
              color: 'inherit',
              textDecoration: 'none',
              alignItems: "center",
              fontFamily: 'Noto Serif',
              gap: 1.2,
              '&:hover': {
                cursor: "pointer",
              }
            }}
          >
            <img src={Logo} alt="Logo" height={style.spacing.HEADER_HEIGHT - 40} />
            instrumental
          </Typography>
          <Box sx={{ flexGrow: 1, display: { xs: 'none', md: 'flex' } }}>
            {pages.map((page) => (
              <NavButton
                key={page}
                onClick={ () => {
                  handleCloseNavMenu();
                  navigate(page[1]);
                }}
                sx={{ color: style.colors.BLACK, display: 'block' }}
              >
                <nobr>{page[0]}</nobr>
              </NavButton>
            ))}
          </Box>
          {auth ? 
          <Box sx={{ flexGrow: 0 }}>
            <Tooltip title="Open settings">
              <IconButton onClick={handleOpenUserMenu} sx={{ p: 0 }}>
                <Avatar alt="" src="" />
              </IconButton>
            </Tooltip>
            <Menu
              sx={{ mt: '45px' }}
              id="menu-appbar"
              anchorEl={anchorElUser}
              anchorElOrigin={{
                vertical: 'top',
                horizontal: 'right',
              }}
              keepMounted
              transformOrigin={{
                vertical: 'top',
                horizontal: 'right',
              }}
              open={Boolean(anchorElUser)}
              onClose={handleCloseUserMenu}
            >
              {settings.map((setting) => (
                <MenuItem key={setting} onClick={handleCloseUserMenu}>
                  <Typography textAlign="center">{setting}</Typography>
                </MenuItem>
              ))}
            </Menu>
          </Box>:
          <Box sx={{ flexGrow: 0 }}>
            <Button
              onClick={ () => {
                handleCloseNavMenu();
                navigate('/sign-in');
              }}
              sx={{ 
                ml: 3,
                px: { sm:1.5 },
                fontSize: { xs: 11, sm: 13 },
                color:"white", 
                display: 'block', 
                backgroundColor: style.colors.PRIMARY,
                border: `2px solid ${style.colors.PRIMARY}`,
                '&:hover': {
                  backgroundColor: style.colors.SECONDARY,
                  color: style.colors.PRIMARY, 
                },
              }}
            >
              <nobr>Sign In</nobr>
            </Button>
          </Box>
          }
        </Toolbar>
      </Container>
    </AppBar>
  );
}
export default NavBar;