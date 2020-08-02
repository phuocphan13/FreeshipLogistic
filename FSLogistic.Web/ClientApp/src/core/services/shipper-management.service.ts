import { Injectable, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { apiHost } from "../consts/const";
import { ShipperDataModel } from "../models/shipper-data.model";
import { ResponeModel } from "../models/response.model";

@Injectable()
export class ShipperManagementService {

  private homeAddress = 'ShipperManagement';

  constructor(public httpClient: HttpClient) {
  }

  get(): Observable<ResponeModel> {
    return this.httpClient.get<ResponeModel>(`${apiHost}/${this.homeAddress}`);
  }

}
