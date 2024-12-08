// UserCard.tsx
import React from "react";
import { Card, CardContent, CardMedia, Typography } from "@mui/material";
import { Link } from "react-router-dom";
import { IUser } from "../../../../interfaces/users";

interface UserCardProps {
  user: IUser;
}

const UserCard: React.FC<UserCardProps> = ({ user }) => {
  return (
    <Link to={`/user/${user.id}`} style={{ textDecoration: "none" }}>
      <Card style={{ width: "100%", maxWidth: "100%" }}>
        <CardMedia
          component="img"
          height="250"
          image={user.avatar}
          alt={user.email}
        />
        <CardContent>
          <Typography gutterBottom variant="h5" component="div">
            {user.first_name} {user.last_name}
          </Typography>
          <Typography variant="body2" color="text.secondary">
            Email: {user.email}
          </Typography>
        </CardContent>
      </Card>
    </Link>
  );
};

export default UserCard;