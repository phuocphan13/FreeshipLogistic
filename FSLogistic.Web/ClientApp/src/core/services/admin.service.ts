import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { apiHost } from "../consts/const";

@Injectable()
export class AdminService {

    private homeAddress = 'api/Admin';

    constructor(public httpClient: HttpClient) {
    }

    get(): Observable<any> {
        return this.httpClient.get<any>(`${apiHost}/${this.homeAddress}`);
    }

}