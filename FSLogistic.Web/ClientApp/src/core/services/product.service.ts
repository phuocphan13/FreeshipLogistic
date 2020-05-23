import { Injectable, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Product } from "../models/product.model";
import { Observable } from "rxjs";

@Injectable()
export class ProductService {

    private homeAddress = 'api/Product';
    private baseUrl: string;

    constructor(public httpClient: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.baseUrl = baseUrl;
    }

    get(): Observable<Product[]> {
        return this.httpClient.get<Product[]>(`${this.baseUrl}${this.homeAddress}`);
    }
}