import React from "react";
import { Box, Typography, TextField, Button, Snackbar } from "@mui/material";
import useRegistrationToken from "./RegistrationStore";

const RegistrationPage: React.FC = () => {
  const { formData, openSnackbar, snackbarMessage, handleChange, handleCloseSnackbar, handleSubmit } = useRegistrationToken();

  return (
    <Box maxWidth="sm" mx="auto" mt={4} p={3} bgcolor="background.paper">
      <Typography variant="h5" gutterBottom>Registration</Typography>
      <form onSubmit={handleSubmit}>
        <TextField
          label="First Name"
          name="firstName"
          type="text"
          value={formData.firstName}
          onChange={handleChange}
          fullWidth
          margin="normal"
          required
        />
        <TextField
          label="Last Name"
          name="lastName"
          type="text"
          value={formData.lastName}
          onChange={handleChange}
          fullWidth
          margin="normal"
          required
        />
        <TextField
          label="Email"
          name="email"
          type="email"
          value={formData.email}
          onChange={handleChange}
          fullWidth
          margin="normal"
          required
        />
        <TextField
          label="Password"
          name="password"
          type="password"
          value={formData.password}
          onChange={handleChange}
          fullWidth
          margin="normal"
          required
        />
        <Button type="submit" variant="contained" color="primary" fullWidth>
          Register
        </Button>
      </form>
      <Snackbar
        open={openSnackbar}
        autoHideDuration={6000}
        onClose={handleCloseSnackbar}
        message={snackbarMessage}
      />
    </Box>
  );
};

export default RegistrationPage;