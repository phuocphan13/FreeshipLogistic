import { Component, OnInit } from '@angular/core';
import { Customer } from 'src/core/models/customer.model';
import { CustomerService } from 'src/core/services/customer.service';
import { ResponeStatusEnum } from 'src/core/models/shared/respone.model';

@Component({
  selector: 'app-customer-management-datashowing',
  templateUrl: './customer-management-datashowing.component.html',
  styleUrls: ['./customer-management-datashowing.component.scss']
})
export class CustomerManagementDatashowingComponent implements OnInit {

  listCustomers: Customer[] = [];
  listHeaders = ["#", "Code", "Name", "Q1", "Q2", "Q3", "Q4", "Q5", "Q6",
    "Q7", "Q8", "Q9", "Q10", "Q11", "Q12", "QTD", "QGV", "QBTH", "QTB", "QTP", "QBTN", "QPN", "QCC", "QHM", "QBC",
    "QNB", "QCG", " "];

  constructor(private customerService: CustomerService) { }

  ngOnInit() {
    this.customerService.get().subscribe(result => {
      console.log(result);
      if (result.responeStatus == ResponeStatusEnum.Successed) {
        this.listCustomers = result.data;
      }
    })
  }

}
