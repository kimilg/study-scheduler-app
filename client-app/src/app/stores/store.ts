import { createContext, useContext } from "react";
import WorkStore from "./workStore";

interface Store {
    workStore: WorkStore;
}

export const store: Store = {
    workStore: new WorkStore(),
}

export const StoreContext = createContext(store);

export function useStore() {
    return useContext(StoreContext);
}