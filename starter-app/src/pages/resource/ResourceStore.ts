import { makeAutoObservable } from "mobx";
import { getByPage } from "../../api/modules/users";

class ResourceStore {
  resources: any[] = [];
  totalPages: number = 1;
  currentPage: number = 1;

  constructor() {
    makeAutoObservable(this);
  }

  async fetchData(page: number) {
    try {
      const { data, total_pages } = await getByPage(page);
      this.resources = data;
      this.totalPages = total_pages;
      this.currentPage = page;
    } catch (error) {
      console.error("Error fetching resources:", error);
    }
  }

  async changePage(page: number) {
    await this.fetchData(page);
}
}

export default ResourceStore;