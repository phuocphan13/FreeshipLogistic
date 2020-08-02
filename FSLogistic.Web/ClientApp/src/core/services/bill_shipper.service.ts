import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { apiHost } from "../consts/const";
import { ResponeModel } from "../models/shared/respone.model";

@Injectable()
export class Bill_ShipperService {

    private homeAddress = 'Bill_Shipper';

    constructor(public httpClient: HttpClient) {
    }

    get(): Observable<ResponeModel> {
        return this.httpClient.get<ResponeModel>(`${apiHost}/${this.homeAddress}`);
    }

}