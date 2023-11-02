import { useState } from 'react';

const Account = () => {

  const [editUser, setEditUser] = useState({});
  const [errors, setErrors] = useState([]);

  // Call useApi or useEffect hook to gather user information from backend
  // and prefill form fields

  const handleChange = (e) => {
    setEditUser({ ...editUser, [e.target.name]: e.target.value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      const result = await axios.patch("/api/auth/edituser", editUser)
      setCredentials(result.data);
      navigate('/'); // navigate back to account info page
    } catch (err) {
      const errorData = err.response.data.errors || err.response.data
      const errorMessages = Object.values(errorData).flat();
      setErrors(errorMessages);
    }
  };

  // if student only
  return (
    <div>
      <h2>Edit User Information:</h2>
      <form onSubmit={handleSubmit}>

      </form>
    </div>
  )

  // else if teacher role associated
  return (
    <div>
      <h2>Edit Teacher Information:</h2>
      <form onSubmit={handleSubmit}>

      </form>
    </div>
  )
}

export default Account;
