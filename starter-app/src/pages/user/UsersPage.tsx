import React, { useEffect } from "react";
import { observer } from "mobx-react-lite";
import { Pagination } from "@mui/material";
import UserCardList from "../../pages/user/component/user/UserCardList";
import UsersStore from "../../pages/user/UsersStore";

const store = new UsersStore();

const UsersPage: React.FC = observer(() => {
  useEffect(() => {
    store.prefetchData(); 
  }, []);

  return (
    <div style={{ display: 'flex', flexDirection: 'column', alignItems: 'center' }}>
      <div style={{ margin: '20px' }}>
        {store.isLoading ? (
          <div>Loading...</div>
        ) : (
          <UserCardList users={store.users} />
        )}
      </div>
      <Pagination
        count={store.totalPages}
        page={store.currentPage}
        onChange={async (event, page)=> await store.changePage(page)}
        variant="outlined"
        shape="rounded"
        style={{ marginTop: '20px', display: 'flex', justifyContent: 'center' }}
      />
    </div>
  );
});

export default UsersPage;