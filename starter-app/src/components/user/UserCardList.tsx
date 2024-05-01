import React from "react";
import { Grid } from "@mui/material";
import UserCard from "../../components/user/UserCard";

interface UserCardListProps {
  users: any[];
}

const UserCardList: React.FC<UserCardListProps> = ({ users }) => {
  return (
    <Grid container spacing={4}>
      {users.map((user) => (
        <Grid item key={user.id}>
          <UserCard user={user} />
        </Grid>
      ))}
    </Grid>
  );
};

export default UserCardList;