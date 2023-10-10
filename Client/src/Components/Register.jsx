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

const Register = () => {
	const [errors, setErrors] = useState([]);
	const navigate = useNavigate();
	const [registerUser, setRegisterUser] = useState({
		firstName: "",
		lastName: "",
		email: "",
		password: "",
		confirm: ""
	});

	const [credentials, setCredentials] = useLocalStorage("credentials", {});

	const handleChange = (e) => {
		setRegisterUser({ ...registerUser, [e.target.name]: e.target.value });
	};

	const handleSubmit = async (e) => {
		e.preventDefault();
		try {
			const result = await axios.post("/api/auth/register", registerUser)
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
				<h1>Register</h1>
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
						label="First Name"
						type="text"
						name="firstName"
						placeholder="First Name"
						autoFocus
						value={registerUser.firstName}
						onChange={handleChange}
					/>
					<TextField
						className="mb-3"
						required
						fullWidth
						label="Last Name"
						type="text"
						name="lastName"
						placeholder="Last Name"
						value={registerUser.lastName}
						onChange={handleChange}
					/>
					<TextField
						className="mb-3"
						required
						fullWidth
						label="Email"
						type="text"
						name="email"
						placeholder="Email"
						value={registerUser.email}
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
						value={registerUser.password}
						onChange={handleChange}
					/>
					<TextField
						className="mb-3"
						required
						fullWidth
						label="Confirm Password"
						type="password"
						name="confirm"
						placeholder="Confirm Password"
						value={registerUser.confirm}
						onChange={handleChange}
					/>
					<Button
						type="submit"
						variant="contained"
						sx={{
							my: 2
						}}
					>
						Register
					</Button>
					<Grid container direction="column" alignItems="center">
						<Grid item xs>
							<Link component={RouterLink} to={"/sign-in"} variant="body2">
								Sign In
							</Link>
						</Grid>
					</Grid>
				</Box>
			</Box>
		</Container>
	)
}

export default Register;
