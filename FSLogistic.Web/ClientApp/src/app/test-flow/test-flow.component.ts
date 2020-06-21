import { Component, OnInit } from '@angular/core';
import { Product } from 'src/core/models/product.model';
import { ProductService } from 'src/core/services/product.service';
import { TestFlowService } from 'src/core/services/test-flow.service';
import { TestFlow } from 'src/core/models/test-flow.model';
import { SummaryModel } from '../../core/models/summary.model';

@Component({
  selector: 'app-test-flow',
  templateUrl: './test-flow.component.html',
  styleUrls: ['./test-flow.component.css']
})
export class TestFlowComponent implements OnInit {
  public testFlows: TestFlow[];
  public testFlowCreate: SummaryModel;
  constructor(private testFlowService: TestFlowService) { }



  ngOnInit() {
    this.testFlowCreate = new SummaryModel();
    this.testFlowService.get().subscribe(result => {
      this.testFlows = result;
      console.log(this.testFlows);
      this.testFlowCreate.id = 0;
      this.testFlowCreate.note = 'Phat';
      this.testFlowCreate.title = 'tien dien';
      this.testFlowCreate.total = '90000';
      this.testFlowService.create(this.testFlowCreate).subscribe(result => {
        console.log(result);
      })
    },
      error => console.error(error))
  }



}
