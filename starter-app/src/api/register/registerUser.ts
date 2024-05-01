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