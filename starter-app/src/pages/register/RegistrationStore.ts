import { useState } from "react";
import { registerUser } from "../../api/modules/users";

const RegistrationStore = () => {
  const [formData, setFormData] = useState({
    email: "",
    password: "",
    firstName: "",
    lastName: "",
  });
  const [openSnackbar, setOpenSnackbar] = useState(false);
  const [snackbarMessage, setSnackbarMessage] = useState("");

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };

  const handleCloseSnackbar = () => {
    setOpenSnackbar(false);
  };

  const handleSubmit = async (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    try {
      const data = await registerUser(formData);
      setSnackbarMessage(`Registration successful! User ID: ${data.id}`);
      setOpenSnackbar(true);
    } catch (error) {
      console.error("Error registering user:", error);
      setSnackbarMessage("Registration failed. Please try again.");
      setOpenSnackbar(true);
    }
  };

  return { formData, openSnackbar, snackbarMessage, handleChange, handleCloseSnackbar, handleSubmit };
};

export default RegistrationStore;