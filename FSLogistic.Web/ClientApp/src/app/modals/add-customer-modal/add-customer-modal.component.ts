import { Component, OnInit } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { AddCustomer } from 'src/core/models/add-customer.model';
import { CustomerService } from 'src/core/services/customer.service';
import { ResponeModel, ResponeStatusEnum } from 'src/core/models/shared/respone.model';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { AlertService } from 'ngx-alerts';

@Component({
  selector: 'app-add-customer-modal',
  templateUrl: './add-customer-modal.component.html',
  styleUrls: ['./add-customer-modal.component.scss']
})
export class AddCustomerModalComponent implements OnInit {

  constructor(private bsModalRef: BsModalRef,
    private customerService: CustomerService,) { }

  customer: AddCustomer = new AddCustomer();

  customerFormGroup: FormGroup;

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
    this.createFormGroup();
  }

  onClickCancel() {
    this.bsModalRef.hide();
  }

  private createFormGroup() {
    this.customerFormGroup = new FormGroup({
      name: new FormControl('', [
        Validators.required,
        Validators.pattern("^[a-zA-Z aàảãáạăằẳẵắặâầẩẫấậbcdđĐeèẻẽéẹêềểễếệfghiìỉĩíịjklmnoòỏõóọôồổỗốộơờởỡớợpqrstuùủũúụưừửữứựvwxyỳỷỹýỵz]+$")
      ]),
      code: new FormControl('', [
        Validators.required,
        Validators.pattern("^[a-zA-Z0-9 ]*$")
      ]),
      q1: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
      q2: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
      q3: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
      q4: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
      q5: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
      q6: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
      q7: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
      q8: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
      q9: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
      q10: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
      q11: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
      q12: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
      qtd: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
      qgv: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
      qbth: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
      qtb: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
      qtp: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
      qbtn: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
      qpn: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
      qcc: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
      qhm: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
      qbc: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
      qnb: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
      qcg: new FormControl('', [
        Validators.required,
        Validators.pattern("^[0-9]*$"),
      ]),
    })
  }

  onClickAdd() {
    this.customer.code = this.code;
    this.customer.name = this.name;
    this.customer.q1 = this.q1;
    this.customer.q2 = this.q2;
    this.customer.q3 = this.q3;
    this.customer.q4 = this.q4;
    this.customer.q5 = this.q5;
    this.customer.q6 = this.q6;
    this.customer.q7 = this.q7;
    this.customer.q8 = this.q8;
    this.customer.q9 = this.q9;
    this.customer.q10 = this.q10;
    this.customer.q11 = this.q11;
    this.customer.q12 = this.q12;
    this.customer.qbc = this.qbc;
    this.customer.qbth = this.qbth;
    this.customer.qbtn = this.qbtn;
    this.customer.qcc = this.qcc;
    this.customer.qcg = this.qcg;
    this.customer.qgv = this.qgv;
    this.customer.qhm = this.qhm;
    this.customer.qnb = this.qnb;
    this.customer.qpn = this.qpn;
    this.customer.qtb = this.qtb;
    this.customer.qtd = this.qtd;
    this.customer.qtp = this.qtp;
    this.customerService.create(this.customer).subscribe(result => {
      if(result.responeStatus == 1){
        alert(result.message);
        location.reload();
        this.bsModalRef.hide;
      }
    })
  }
}
