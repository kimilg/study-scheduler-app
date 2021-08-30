import axios, { AxiosResponse } from "axios";
import { Work } from "../models/work";

axios.defaults.baseURL = 'http://localhost:5000/api';

const responseBody = <T> (response: AxiosResponse<T>) => response.data;

const requests = {
    get: <T> (url: string) => axios.get<T>(url).then(responseBody),
    post: <T> (url: string, body: {}) => axios.post<T>(url, body).then(responseBody),
    put: <T> (url: string, body: {}) => axios.put<T>(url, body).then(responseBody),
    del: <T> (url: string) => axios.delete<T>(url).then(responseBody)
}

const Works = {
    list: () => requests.get<Work[]>('/works'),
    details: (id: string) => requests.get<Work>(`/works/${id}`),
    create: (work: Work) => requests.post<void>('/works', work),
    update: (id: string, work: Work) => requests.put<void>(`/works/${id}`, work),
    delete: (id: string) => requests.del<void>(`/works/${id}`),
} 

const agent = {
    Works
}

export default agent;