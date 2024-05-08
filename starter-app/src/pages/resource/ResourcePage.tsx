import React, { useEffect } from "react";
import { Box, Typography, Pagination } from "@mui/material";
import ResourceCardList from "./component/resource/ResourceCardList";
import ResourceStore from "./ResourceStore";
import { observer } from "mobx-react-lite";

const store = new ResourceStore();

const ResourcePage: React.FC = observer(() => {
  useEffect(() => {
    store.fetchData(1);
  }, []);

  return (
    <Box marginLeft={"100px"} marginRight={"100px"} marginTop={5}>
      <Typography variant="h5" gutterBottom>Resources</Typography>
      <ResourceCardList resources={store.resources} />
      <Pagination
        count={store.totalPages}
        page={store.currentPage}
        onChange={async (event, page)=> await store.changePage(page)}
        variant="outlined"
        shape="rounded"
        style={{ marginTop: '20px', display: 'flex', justifyContent: 'center' }}
      />
    </Box>
  );
});

export default ResourcePage;