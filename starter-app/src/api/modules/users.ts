import apiClient from "../client";

export const getById = (id: string) => apiClient({
  path: `users/${id}`,
  method: 'GET'
})

export async function getByPageUsers(page: number) {
  const response = await fetch(`https://reqres.in/api/users?page=${page}`);
  if (!response.ok) {
    throw new Error("Failed to fetch resources");
  }
  const data = await response.json();
  return data;
}

export async function getByPage(page: number) {
  const response = await fetch(`https://reqres.in/api/resources?page=${page}`);
  if (!response.ok) {
    throw new Error("Failed to fetch resources");
  }
  const data = await response.json();
  return data;
}

export async function loginUser(email: string, password: string) {
  const response = await fetch("https://reqres.in/api/login", {
      method: "POST",
      headers: {
          "Content-Type": "application/json",
      },
      body: JSON.stringify({ email, password }),
  });

  if (!response.ok) {
      throw new Error("Failed to login user");
  }

  const data = await response.json();
  return data;
}

export async function registerUser(formData: any) {
  const response = await fetch("https://reqres.in/api/register", {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(formData),
  });

  if (!response.ok) {
    throw new Error("Failed to register user");
  }

  const data = await response.json();
  return data;
}