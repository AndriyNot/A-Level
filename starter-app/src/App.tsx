import React from "react";
import { CssBaseline, ThemeProvider, AppBar, Toolbar, Typography, Button, IconButton } from "@mui/material";
import { BrowserRouter as Router, Routes, Route, Link } from "react-router-dom";
import UsersPage from "./pages/user/UsersPage";
import ResourcePage from "./pages/resource/ResourcePage";
import RegistrationPage from "./pages/register/RegistrationPage";
import { theme } from "./theme";

function App() {
  return (
    <ThemeProvider theme={theme}>
      <CssBaseline />
      <Router>
        <AppBar position="static" sx={{ backgroundColor: '#808080' }}>
          <Toolbar>
            <Typography variant="h6" component="div" sx={{ flexGrow: 1 }}>
                Logo
            </Typography>
            <Button color="inherit" component={Link} to="/users">Users</Button>
            <Button color="inherit" component={Link} to="/resources">Resources</Button>
            <Button color="inherit" component={Link} to="/register">Register</Button>
          </Toolbar>
        </AppBar>
        <Routes>
          <Route path="/users" element={<UsersPage />} />
          <Route path="/resources" element={<ResourcePage />} />
          <Route path="/register" element={<RegistrationPage />} /> {/* Додайте закриваючий тег > */}
        </Routes>
      </Router>
    </ThemeProvider>
  );
}

export default App;
