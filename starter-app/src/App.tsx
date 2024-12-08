import React from "react";
import { CssBaseline, ThemeProvider,CardMedia } from "@mui/material";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import { observer } from "mobx-react-lite";
import { theme } from "./theme";
import CustomAppBar from "./CustomAppBar";
import CustomAppBarBottom from "./CustomAppBarBottom";
import UsersPage from "./pages/user/UsersPage";
import ResourcePage from "./pages/resource/ResourcePage";
import RegistrationPage from "./pages/register/RegistrationPage";
import LoginPage from "./pages/login/LoginPage";
import UserPage from "./pages/user/UserPage";
import unnamed from './unnamed.png';

const App: React.FC = observer(() => {
  return (
    <ThemeProvider theme={theme}>
      <CssBaseline />
      <Router>
          <CustomAppBar />
          <Routes>
            <Route path="/users" element={<UsersPage />} />
            <Route path="/resources" element={<ResourcePage />} />
            <Route path="/registration" element={<RegistrationPage />} />
            <Route path="/login" element={<LoginPage />} />
            <Route path="/user/:id" element={<UserPage />} /> 
          </Routes>
          <CustomAppBarBottom />
        
      </Router>
    </ThemeProvider>
  );
});

export default App;