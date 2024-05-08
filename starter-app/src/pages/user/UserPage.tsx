import React, { ReactElement, FC, useEffect } from "react";
import { Card, CardContent, CardMedia, CircularProgress, Container, Grid, Typography } from '@mui/material';
import { useParams } from "react-router-dom";
import { observer } from "mobx-react-lite";
import UserStore from "./UserStore";

const store = new UserStore();

const UserPage: FC<any> = observer((): ReactElement => {
    const { id } = useParams<{ id: string }>();

    useEffect(() => {
        if (id) {
            store.fetchUser(id);
        }
    }, [id]);

    return (
        <Container>
            <Grid container spacing={4} justifyContent="center" m={4}>
                {store.isLoading ? (
                    <CircularProgress />
                ) : (
                    <>
                        {store.user && (
                            <Card sx={{ maxWidth: 250 }}>
                                <CardMedia
                                    component="img"
                                    height="250"
                                    image={store.user.avatar}
                                    alt={store.user.email}
                                />
                                <CardContent>
                                    <Typography noWrap gutterBottom variant="h6" component="div">
                                        {store.user.email}
                                    </Typography>
                                    <Typography variant="body2" color="text.secondary">
                                        {store.user.first_name} {store.user.last_name}
                                    </Typography>
                                </CardContent>
                            </Card>
                        )}
                    </>
                )}
            </Grid>
        </Container>
    );
});

export default UserPage;