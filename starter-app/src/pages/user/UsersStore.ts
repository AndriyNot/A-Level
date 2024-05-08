import { makeAutoObservable, runInAction } from "mobx";
import { getByPageUsers } from "../../api/modules/users";
import { IUser } from "../../interfaces/users";

class UsersStore {
    users: IUser[] = [];
    totalPages = 0;
    currentPage = 1;
    isLoading: boolean = false;

    constructor() {
        makeAutoObservable(this);
    }

    async prefetchData(page: number = this.currentPage) {
        try {
            this.isLoading = true;
            const res = await getByPageUsers(page);
            runInAction(() => {
                this.users = res.data;
                this.totalPages = res.total_pages;
                this.currentPage = page;
            });
        } catch (e) {
            if (e instanceof Error) {
                console.error(e.message);
            }
        } finally {
            this.isLoading = false;
        }
    }

    async changePage(page: number) {
        await this.prefetchData(page);
    }
}

export default UsersStore;