import React from "react";
import { Card, CardContent, Typography } from "@mui/material";

interface UserCardProps {
  user: any;
}

const UserCard: React.FC<UserCardProps> = ({ user }) => {
  return (
    <Card>
      <CardContent>
      <img src={user.avatar} alt={user.first_name} style={{ width: '100%' }} />
        <Typography variant="h6" component="h2">
          {user.first_name} {user.last_name}
        </Typography>
        <Typography variant="body2" color="textSecondary" component="p">
          Id: {user.id}
          <br />
          Email:<br /> {user.email}
        </Typography>
      </CardContent>
    </Card>
  );
};

export default UserCard;