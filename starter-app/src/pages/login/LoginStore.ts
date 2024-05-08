import { makeAutoObservable } from "mobx";
import { loginUser } from "../../api/modules/users";
import AuthStore from "../../store";

class LoginStore {
  constructor() {
    makeAutoObservable(this);
  }

  async login(email: string, password: string) {
    try {
      const data = await loginUser(email, password);
      AuthStore.setToken(data.token);
      return true;
    } catch (error) {
      console.error("Error logging in:", error);
      throw new Error("Login failed. Please try again.");
    }
  }
}

export default LoginStore;