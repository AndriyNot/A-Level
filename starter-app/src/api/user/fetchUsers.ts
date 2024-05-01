export async function fetchUsers(page: number) {
    const response = await fetch(`https://reqres.in/api/users?page=${page}`);
    if (!response.ok) {
      throw new Error("Failed to fetch users");
    }
    const data = await response.json();
    return data;
  }