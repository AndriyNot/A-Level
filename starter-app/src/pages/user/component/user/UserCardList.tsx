import React from "react";
import { Grid } from "@mui/material";
import UserCard from "./UserCard";
import { IUser } from "../../../../interfaces/users";

interface UserCardListProps {
  users: IUser[];
}

const UserCardList: React.FC<UserCardListProps> = ({ users }) => {
  return (
    <Grid container spacing={2} justifyContent="center">
      {users.map((user) => (
        <Grid item key={user.id}>
          <UserCard user={user} />
        </Grid>
      ))}
    </Grid>
  );
};

export default UserCardList;
