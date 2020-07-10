import { Component, OnInit } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { AddCustomer } from 'src/core/models/add-customer.model';
import { CustomerService } from 'src/core/services/customer.service';

@Component({
  selector: 'app-add-customer-modal',
  templateUrl: './add-customer-modal.component.html',
  styleUrls: ['./add-customer-modal.component.scss']
})
export class AddCustomerModalComponent implements OnInit {

  constructor(private bsModalRef:BsModalRef,
    private customerService:CustomerService,) { }

  customer:AddCustomer = new AddCustomer();

  code: string;
  name: string;
  q1: number;
  q2: number;
  q3: number;
  q4: number;
  q5: number;
  q6: number;
  q7: number;
  q8: number;
  q9: number;
  q10: number;
  q11: number;
  q12: number;
  qtd: number;
  qgv: number;
  qbth: number;
  qtb: number;
  qtp: number;
  qbtn: number;
  qpn: number;
  qcc: number;
  qhm: number;
  qbc: number;
  qnb: number;
  qcg: number;

  ngOnInit() {
  }

  onClickCancel() {
    this.bsModalRef.hide();
  }

  onClickAdd(){
    this.customer.code=this.code;
    this.customer.name=this.name;
    this.customer.q1=this.q1;
    this.customer.q2=this.q2;
    this.customer.q3=this.q3;
    this.customer.q4=this.q4;
    this.customer.q5=this.q5;
    this.customer.q6=this.q6;
    this.customer.q7=this.q7;
    this.customer.q8=this.q8;
    this.customer.q9=this.q9;
    this.customer.q10=this.q10;
    this.customer.q11=this.q11;
    this.customer.q12=this.q12;
    this.customer.qbc=this.qbc;
    this.customer.qbth=this.qbth;
    this.customer.qbtn=this.qbtn;
    this.customer.qcc=this.qcc;
    this.customer.qcg=this.qcg;
    this.customer.qgv=this.qgv;
    this.customer.qhm=this.qhm;
    this.customer.qnb=this.qnb;
    this.customer.qpn=this.qpn;
    this.customer.qtb=this.qtb;
    this.customer.qtd=this.qtd;
    this.customer.qtp=this.qtp;
    console.log(this.customer);
    this.customerService.create(this.customer).subscribe(result => {
      alert(result.message);
      location.reload();
      this.bsModalRef.hide();
    })
  }
}
