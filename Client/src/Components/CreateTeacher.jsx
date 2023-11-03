import { useEffect, useState } from 'react';
import styles from '../Styles/App';
import useLocalStorage from '../Hooks/useLocalStorage';
import { useNavigate, Link as RouterLink } from 'react-router-dom';
import axios from 'axios';
import '../Styles/LoginReg.css';
import Button from '@mui/material/Button';
import TextField from '@mui/material/TextField';
import CssBaseline from '@mui/material/CssBaseline';
import Typography from '@mui/material/Typography';
import Container from '@mui/material/Container';
import Grid from '@mui/material/Grid';
import Link from '@mui/material/Link';
import Box from '@mui/material/Box';
import useApi from '../Hooks/useApi';
import { MenuItem, Select } from '@mui/material';

const CreateTeacher = () => {
  const [instrumentList, setInstrumentList] = useState([]);
	const [errors, setErrors] = useState([]);
	const navigate = useNavigate();
	const [newTeacher, setNewTeacher] = useState({
		firstName: "",
		lastName: "",
		email: "",
		password: "",
    confirm: "",
    instrumentId: 0
	});

  const [credentials, setCredentials] = useLocalStorage("credentials", {});
  const { handleSubmit , data} = useApi();

  const url = "/api/instructor/create"

  const handleManualSubmit = async (e) => {
    e.preventDefault();
    handleSubmit(url, newTeacher, "POST");
  };

	const handleChange = (e) => {
		setNewTeacher({ ...newTeacher, [e.target.name]: e.target.value });
  };

  const fetchInstrumentList = async () => {
    try {
      const result = await axios.get("/api/instrument/all");
      setInstrumentList([...result.data].sort((a, b) => a.name.localeCompare(b.name)));
    } catch (error) {
      // Handle error here (e.g., show an error message)
      console.error("Error fetching instrument list:", error);
    }
  };

  // Fetches instrument list and saves reference to unfiltered list on page render
  useEffect(() => {
    fetchInstrumentList();
      if (data) {
        navigate('/teacher_creation_success', {state:data});
      }
  }, [data]);

	return (
		<Container component="main" maxWidth="xs">
			<CssBaseline />
			<Box
				sx={{
					marginTop: 8,
					display: 'flex',
					flexDirection: 'column',
					alignItems: 'center',
					backgroundColor: "white",
					width: "360px",
					padding: "40px 20px",
					borderRadius: "10px",
				}}
			>
				<Typography variant='h5' sx={{
					fontWeight: "bold",
					opacity: .8,
					color: styles.colors.PRIMARY,
					mb: 1,
				}}
				>
					Create a new Teacher
				</Typography>
				{
					errors.map((v, i) => <p key={i} className="errorStyle">{v}</p>)
				}
				<Box component="form" onSubmit={(e)=>handleManualSubmit(e)}
					sx={{
						mt: 2,
						display: "flex",
						flexWrap: "wrap",
						justifyContent: "center"
					}}>
					<TextField
						className="mb-3"
						required
						color='success'
						fullWidth
						label="First Name"
						type="text"
						name="firstName"
						placeholder="Insert your first name"
						autoFocus
						value={newTeacher.firstName}
						onChange={handleChange}
					/>
					<TextField
						className="mb-3"
						required
						color='success'
						fullWidth
						label="Last Name"
						type="text"
						name="lastName"
						placeholder="Insert your last name"
						value={newTeacher.lastName}
						onChange={handleChange}
					/>
					<TextField
						className="mb-3"
						required
						color='success'
						fullWidth
						label="Email"
						type="text"
						name="email"
						placeholder="yourname@mail.com"
						value={newTeacher.email}
						onChange={handleChange}
					/>
					<TextField
						className="mb-3"
						required
						color='success'
						fullWidth
						label="Password"
						type="password"
						name="password"
						placeholder="Create a password"
						value={newTeacher.password}
						onChange={handleChange}
					/>
					<TextField
						className="mb-3"
						required
						color='success'
						fullWidth
						label="Confirm Password"
						type="password"
						name="confirm"
						placeholder="Repeat your password"
						value={newTeacher.confirm}
						onChange={handleChange}
          />
          <Select
            label="Select Instrument"
            value={newTeacher.instrumentId || ""}
            name="instrumentId"
            displayEmpty
            onChange={handleChange}
            renderValue={newTeacher.instrumentId ? undefined : () => <div style={{ color: 'grey' }}>Select Instrument</div>}
          >
          {instrumentList.map((instrument, index) => (
            <MenuItem key={instrument.instrumentId} value={instrument.instrumentId}>{instrument.name}</MenuItem>
          ))}
          </Select>
					<Button
						type="submit"
						color='warning'
						disableElevation
						variant="contained"
						sx={{
							width: "100%",
							my: 1,
							py: 1.1,
							fontWeight: "bold",
							textTransform: "none",
						}}
					>
						Create Teacher
					</Button>
				</Box>
			</Box>
		</Container>
	)
}

export default CreateTeacher;
