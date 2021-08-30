import { makeAutoObservable, runInAction } from "mobx";
import agent from "../api/agent";
import { Work } from "../models/work";

export default class WorkStore {
    works : Work[] | null = null;
    loading = false;
    constructor() {
        makeAutoObservable(this)
    }

    loadWorks = async () => {
        this.loading = true;
        try {
            this.works = await agent.Works.list();
            runInAction(() => {
                this.loading = false;
            });
        } catch (error) {
            console.log(error);
            runInAction(() => {
                this.loading = false;
            })
        }
    }
}