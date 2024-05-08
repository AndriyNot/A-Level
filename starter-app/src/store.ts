import { makeAutoObservable } from "mobx";

class Store {
  token: string | null = null;

    constructor() {
        makeAutoObservable(this);
        const storedToken = localStorage.getItem("token");
        if (storedToken) {
            this.setToken(storedToken);
        }
    }

    setToken(token: string) {
        this.token = token;
        localStorage.setItem("token", token);
    }

    clearToken() {
        this.token = null;
        localStorage.removeItem("token");
    }
}

export default new Store();
export {};