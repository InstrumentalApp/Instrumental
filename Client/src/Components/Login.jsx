import { useState } from 'react';
import useLocalStorage from '../Hooks/useLocalStorage';
import { useNavigate, Link as RouterLink } from 'react-router-dom';
import axios from 'axios';
import '../Styles/LoginReg.css';
import HoverButton from './HoverButton';
import TextField from '@mui/material/TextField';
import Container from '@mui/material/Container';
import Grid from '@mui/material/Grid';
import Link from '@mui/material/Link';
import Box from '@mui/material/Box';
import Typography from '@mui/material/Typography';
import styles from '../Styles/App';

const Login = () => {
  const [errors, setErrors] = useState([]);
  const navigate = useNavigate();
  const [loginUser, setLoginUser] = useState({
    email: "",
    password: ""
  });

  const [credentials, setCredentials] = useLocalStorage("credentials", {});

  const handleChange = (e) => {
    setLoginUser({ ...loginUser, [e.target.name]: e.target.value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      const result = await axios.post("/api/auth/login", loginUser)
      setCredentials(result.data);
      navigate('/');
    } catch (err) {
      const errorData = err.response.data.errors || err.response.data
      const errorMessages = Object.values(errorData).flat();
      setErrors(errorMessages);
    }
  };

  return (
    <Container component="main" maxWidth="xs">
      <Box
        sx={{
          marginTop: 8,
          display: 'flex',
          flexDirection: 'column',
          alignItems: 'center',
        }}
      >
        <Typography variant='h5' sx={{ fontWeight: "bold", opacity: .5 }}>Sign into your Instrumental account</Typography>
        {
          errors.map((v, i) => <p key={i} className="errorStyle">{v}</p>)
        }
        <Box component="form" onSubmit={handleSubmit}
          sx={{
            mt: 2,
            display: "flex",
            flexWrap: "wrap",
            justifyContent: "center"
          }}>
          <TextField
            className="mb-3"
            required
            color="success"
            fullWidth
            label="Email"
            type="text"
            name="email"
            placeholder="Email"
            autoFocus
            value={loginUser.email}
            onChange={handleChange}
          />
          <TextField
            className="mb-3"
            required
            color="success"
            fullWidth
            label="Password"
            type="password"
            name="password"
            placeholder="Password"
            value={loginUser.password}
            onChange={handleChange}
          />
          <HoverButton
            type="submit"
            backgroundColor={styles.colors.ACTION}
            margin="5px 0"
          >
            Sign In
          </HoverButton>
          <Grid container direction="column" alignItems="center" pt={2}>
            <Grid item xs>
              <Link href="#" underline="hover" variant="body2" 
                sx={{ color: styles.colors.PRIMARY,
                  fontWeight: "bold",
                  opacity: .8
                }} 
              >
                Forgot password?
              </Link>
            </Grid>
            <Grid item>
              <Link component={RouterLink} to={"/register"} underline="hover" variant="body2" 
                sx={{ color: styles.colors.PRIMARY,
                  fontWeight: "bold",
                  opacity: .7
                }} 
              >
                Register as a new user
              </Link>
            </Grid>
          </Grid>
        </Box>
      </Box>
    </Container>
  );
}

export default Login;
