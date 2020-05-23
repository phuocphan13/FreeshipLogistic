import { Injectable, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Product } from "../models/product.model";
import { Observable } from "rxjs";
import { apiHost } from "../consts/const";

@Injectable()
export class ProductService {

    private homeAddress = 'api/Product';

    constructor(public httpClient: HttpClient) {
    }

    get(): Observable<Product[]> {
        return this.httpClient.get<Product[]>(`${apiHost}/${this.homeAddress}`);
    }
}