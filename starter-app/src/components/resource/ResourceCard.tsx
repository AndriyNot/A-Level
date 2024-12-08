import React from "react";
import { Card, CardContent, Typography } from "@mui/material";

interface ResourceCardProps {
  resource: any;
}

const ResourceCard: React.FC<ResourceCardProps> = ({ resource }) => {
  return (
    <Card style={{ backgroundColor: resource.color }}>
      <CardContent>
        <Typography variant="h6" component="h2">
          {resource.name}
        </Typography>
        <Typography variant="body2" color="textSecondary">
          Year: {resource.year}
        </Typography>
        <Typography variant="body2" color="textSecondary">
          Color: {resource.color}
        </Typography>
        <Typography variant="body2" color="textSecondary">
          Pantone Value: {resource.pantone_value}
        </Typography>
      </CardContent>
    </Card>
  );
};

export default ResourceCard;