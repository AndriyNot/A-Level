import { makeAutoObservable } from "mobx";
import * as userApi from "../../api/modules/users";
import { IUser } from "../../interfaces/users";

class UserStore {
    user: IUser | null = null;
    isLoading: boolean = false;

    constructor() {
        makeAutoObservable(this);
    }

    async fetchUser(id: string) {
        try {
            this.isLoading = true;
            const res = await userApi.getById(id);
            this.user = res.data;
        } catch (e) {
            if (e instanceof Error) {
                console.error(e.message);
            }
        } finally {
            this.isLoading = false;
        }
    }
}

export default UserStore;