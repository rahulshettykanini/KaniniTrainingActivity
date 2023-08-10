// import React, { useState } from 'react';
// import { Button } from '@mui/material';
// import { Typography } from '@mui/material';
// import { TextField } from '@mui/material';
// import { Container } from '@mui/material';
// import axios from 'axios';

// import { BrowserRouter, Routes, Route, Link } from 'react-router-dom';

// const LoginPage = () => {

//     const [formData, setFormData] = useState({
//         email: '',
//         password: '',
//       });
    
//       const handleChange = (e) => {
//         setFormData({ ...formData, [e.target.name]: e.target.value });
//       };
    
//       const handleSubmit = async (e) => {
//         e.preventDefault();
//         try {
//           const response = await axios.post('https://localhost:7112/api/Users/login', formData, {
//             headers: {
//               'Content-Type': 'application/json',
//             },
//           });
    
//           console.log('Login success:', response.data); // The token will be printed in the console


//         } 
        
//         catch (error) {
//           console.error('Error during login:', error.response.data);
//         }

//       };

//     return (
// <Container maxWidth="sm">
//       <Typography variant="h4" gutterBottom>
//         User Login
//       </Typography>
//       <form onSubmit={handleSubmit}>
//         <TextField
//           label="Email"
//           name="email" // Use 'emailId' instead of 'email'
//           type="email"
//           value={formData.email}
//           onChange={handleChange}
//           fullWidth
//           margin="normal"
//           variant="outlined"
//         />
//         <TextField
//           label="Password"
//           name="password"
//           type="password"
//           value={formData.password}
//           onChange={handleChange}
//           fullWidth
//           margin="normal"
//           variant="outlined"
//         />
//         <Button type="submit" variant="contained" color="primary">       
//         Login
//         </Button>
//       </form>
//     </Container>

//     );
// };


//export default LoginPage;



import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import { Button } from '@mui/material';
import { Typography } from '@mui/material';
import { TextField } from '@mui/material';
import { Container } from '@mui/material';
import axios from 'axios';
import jwt_decode from 'jwt-decode'; 

const LoginPage = ({setid ,setRole,Role}) => {

 const navigate =useNavigate();
  

  const [formData, setFormData] = useState({
    email: '',
    password: '',
  });

  const handleChange = (e) => {
    setFormData({ ...formData, [e.target.name]: e.target.value });
  };




  const handleSubmit = async (e) => {
    e.preventDefault();
    try {
      const response = await axios.post('https://localhost:7112/api/Users/login', formData, {
        headers: {
          Authorization: `Bearer ${localStorage.getItem('authToken')}`,
        },
      });
      
      const encodedToken = response.data;
      const decodedToken = jwt_decode(encodedToken);
      const UserId = decodedToken.nameid;
      setid(UserId);
      const UserRole = decodedToken.role;
      setRole(UserRole);
      // localStorage.setItem('decodedToken', JSON.stringify(decodedToken));
      console.log('Decoded Token:', decodedToken);
      console.log('UserId:', UserId);
      console.log('UserRole:', UserRole);
      console.log('Login success:', response.data);  

      //  navigate('/agent');


    }
    catch (error) {
      if (error.response && error.response.data) {
        console.error('Error during login:', error.response.data);
      } else {
        console.error('An error occurred:', error.message);
      }
    }
    
  };

  return (
   


    <Container maxWidth="sm">
      <Typography variant="h4" gutterBottom>
        User Login
      </Typography>
      <form onSubmit={handleSubmit}>
        <TextField
          label="Email"
          name="email" 
          type="email"
          value={formData.email}
          onChange={handleChange}
          fullWidth
          margin="normal"
          variant="outlined"
        />
        <TextField
          label="Password"
          name="password"
          type="password"
          value={formData.password}
          onChange={handleChange}
          fullWidth
          margin="normal"
          variant="outlined"
        />
        <Button type="submit" variant="contained" color="primary">
        Submit
        </Button>
        
      </form>
     
    </Container>
  );
};

export default LoginPage;