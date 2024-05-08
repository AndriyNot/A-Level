import React from "react";
import { AppBar, Toolbar, Typography, Button } from "@mui/material";
import { Link } from "react-router-dom";
import AuthStore from "./store";
import unnamed from './unnamed.png';

const CustomAppBar = () => {
  const handleSignOut = () => {
    AuthStore.clearToken();
  };

  return (
    <AppBar position="static" sx={{ backgroundColor: '#53B0AE' }}>
      <Toolbar>
        <Typography variant="h6" component="div" sx={{ flexGrow: 1 }}>
          Logo
          {AuthStore.token && (
            <Typography color="greenyellow" variant="body1" component="div" sx={{ marginRight: '20px' }}>
              <img src={unnamed} alt="Circle Logo" style={{ width: 30, height: 30, marginRight: 10, borderRadius: '50%' }} />
              {AuthStore.token}
            </Typography>
          )}
        </Typography>
        <Button color="inherit" component={Link} to="/users">Users</Button>
        <Button color="inherit" component={Link} to="/resources">Resources</Button>
        <Button color="inherit" component={Link} to="/registration">Register</Button>
        <Button color="inherit" component={Link} to="/login">Login</Button>
        {AuthStore.token && (
          <Typography variant="body1" component="div" sx={{ marginRight: '20px' }}>
            <Button color="secondary" onClick={handleSignOut}>Sign out</Button>
          </Typography>
        )}
      </Toolbar>
    </AppBar>
  );
};

export default CustomAppBar;