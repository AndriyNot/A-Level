import React from "react";
import { Grid } from "@mui/material";
import ResourceCard from "../../components/resource/ResourceCard";

interface ResourceCardListProps {
  resources: any[];
}

const ResourceCardList: React.FC<ResourceCardListProps> = ({ resources }) => {
  return (
    <Grid container spacing={2}>
      {resources.map((resource) => (
        <Grid item key={resource.id}>
          <ResourceCard resource={resource} />
        </Grid>
      ))}
    </Grid>
  );
};

export default ResourceCardList;