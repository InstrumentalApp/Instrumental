import { useState } from 'react';
import useLocalStorage from '../Hooks/useLocalStorage';
import { useNavigate, Link as RouterLink } from 'react-router-dom';
import axios from 'axios';
import '../Styles/LoginReg.css';
import Button from '@mui/material/Button';
import TextField from '@mui/material/TextField';
import CssBaseline from '@mui/material/CssBaseline';
import Container from '@mui/material/Container';
import Grid from '@mui/material/Grid';
import Link from '@mui/material/Link';
import Box from '@mui/material/Box';

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
      navigate('/hello');
    } catch (err) {
      const errorData = err.response.data.errors || err.response.data
      const errorMessages = Object.values(errorData).flat();
      setErrors(errorMessages);
    }
  };

  return (
    <Container component="main" maxWidth="xs">
      <CssBaseline />
      <Box
        sx={{
          marginTop: 8,
          display: 'flex',
          flexDirection: 'column',
          alignItems: 'center',
        }}
      >
        <h1>Sign in</h1>
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
            fullWidth
            label="Password"
            type="password"
            name="password"
            placeholder="Password"
            value={loginUser.password}
            onChange={handleChange}
          />
          <Button
            type="submit"
            variant="contained"
            sx={{
              my: 2
            }}
          >
            Sign In
          </Button>
          <Grid container direction="column" alignItems="center">
            <Grid item xs>
              <Link href="#" variant="body2">
                Forgot password?
              </Link>
            </Grid>
            <Grid item>
              <Link component={RouterLink} to={"/register"} variant="body2">
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
