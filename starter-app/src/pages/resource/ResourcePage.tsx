import React, { useState, useEffect } from "react";
import { Pagination } from "@mui/material";
import ResourceCardList from "../../components/resource/ResourceCardList";
import { fetchResources } from "../../api/resource/fetchResources";

const ResourcePage: React.FC = () => {
  const [resources, setResources] = useState<any[]>([]);
  const [page, setPage] = useState(1);
  const [totalPages, setTotalPages] = useState(1);

  useEffect(() => {
    async function fetchData() {
      try {
        const { data, total_pages } = await fetchResources(page);
        setResources(data);
        setTotalPages(total_pages);
      } catch (error) {
        console.error("Error fetching resources:", error);
      }
    }

    fetchData();
  }, [page]);

  const handleChangePage = (event: React.ChangeEvent<unknown>, value: number) => {
    setPage(value);
  };

  return (
    <div style={{ padding: '20px', marginLeft: '300px', marginTop: '20px'}}>
      <ResourceCardList resources={resources} />
      <Pagination
        count={totalPages}
        page={page}
        onChange={handleChangePage}
        variant="outlined"
        shape="rounded"
        style={{ marginTop: '20px', display: 'flex', justifyContent: 'center' }}
      />
    </div>
  );
};

export default ResourcePage;