import React from "react";
import { Grid } from "@mui/material";
import ResourceCard from "./ResourceCard";
import { IResource } from "../../../../interfaces/resources";

interface ResourceCardListProps {
  resources: IResource[];
}

const ResourceCardList: React.FC<ResourceCardListProps> = ({ resources }) => {
  return (
    <Grid container spacing={2}>
      {resources.map((resource) => (
        <Grid item xs={2} key={resource.id}>
          <ResourceCard resource={resource} />
        </Grid>
      ))}
    </Grid>
  );
};

export default ResourceCardList;