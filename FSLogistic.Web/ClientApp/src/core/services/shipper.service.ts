import { Injectable, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { apiHost } from "../consts/const";

@Injectable()
export class ShipperService {

    private homeAddress = 'api/Shipper';

    constructor(public httpClient: HttpClient) {
    }

    get(): Observable<any> {
        return this.httpClient.get<any>(`${apiHost}/${this.homeAddress}`);
    }
}