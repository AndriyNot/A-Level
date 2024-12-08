export async function fetchResources(page: number) {
    const response = await fetch(`https://reqres.in/api/resources?page=${page}`);
    if (!response.ok) {
      throw new Error("Failed to fetch resources");
    }
    const data = await response.json();
    return data;
  }