import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { apiHost } from "../consts/const";
import { ResponeModel } from "../models/shared/respone.model";
import { AddCustomer } from "../models/add-customer.model";

@Injectable()
export class CustomerService {

    private homeAddress = 'Customer';

    constructor(public httpClient: HttpClient) {
    }

    get(): Observable<ResponeModel> {
        return this.httpClient.get<ResponeModel>(`${apiHost}/${this.homeAddress}`);
    }

    create(customer: AddCustomer): Observable<any> {
        return this.httpClient.post<any>(`${apiHost}/${this.homeAddress}`, customer)
    }
}