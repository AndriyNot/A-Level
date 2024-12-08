import React, { useState, useEffect } from "react";
import { Pagination } from "@mui/material";
import UserCardList from "../../components/user/UserCardList";
import { fetchUsers } from "../../api/user/fetchUsers";

const UsersPage: React.FC = () => {
  const [users, setUsers] = useState<any[]>([]);
  const [page, setPage] = useState(1);
  const [totalPages, setTotalPages] = useState(1);

  useEffect(() => {
    async function fetchData() {
      try {
        const { data, total_pages } = await fetchUsers(page);
        setUsers(data);
        setTotalPages(total_pages);
      } catch (error) {
        console.error("Error fetching users:", error);
      }
    }

    fetchData();
  }, [page]);

  const handleChangePage = (event: React.ChangeEvent<unknown>, value: number) => {
    setPage(value);
  };

  return (
    <div style={{marginLeft: '300px', marginTop: '20px'}}>
      <UserCardList users={users} />
      <Pagination
        count={totalPages}
        page={page}
        onChange={handleChangePage}
        variant="outlined"
        shape="rounded"
        style={{ marginRight: '300px',marginTop: '20px', display: 'flex', justifyContent: 'center' }}
      />
    </div>
  );
};

export default UsersPage;