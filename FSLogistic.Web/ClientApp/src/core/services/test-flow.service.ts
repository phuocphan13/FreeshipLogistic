import { Injectable, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { apiHost } from "../consts/const";
import { TestFlow } from "../models/test-flow.model";
import { SummaryModel } from "../models/summary.model";

@Injectable()
export class TestFlowService {

  private homeAddress = 'TestFlow';

  constructor(public httpClient: HttpClient) {
  }

  get(): Observable<TestFlow[]> {
    return this.httpClient.get<TestFlow[]>(`${apiHost}/${this.homeAddress}`);
  }
  create(TestFlowCreate): Observable<SummaryModel> {
    return this.httpClient.post<SummaryModel>(`${apiHost}/${this.homeAddress}`, TestFlowCreate);
  }
}
