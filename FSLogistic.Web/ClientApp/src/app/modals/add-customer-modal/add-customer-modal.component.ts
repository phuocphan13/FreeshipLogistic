import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { AddCustomer } from 'src/core/models/add-customer.model';
import { CustomerService } from 'src/core/services/customer.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { CustomerType } from 'src/app/common/customer-enum';

@Component({
  selector: 'app-add-customer-modal',
  templateUrl: './add-customer-modal.component.html',
  styleUrls: ['./add-customer-modal.component.scss']
})
export class AddCustomerModalComponent implements OnInit {

  customerDataCreate = new EventEmitter<any>();

  constructor(private bsModalRef: BsModalRef,
    private customerService: CustomerService,) { }

  customer: AddCustomer = new AddCustomer();

  customerFormGroup: FormGroup;

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
        Validators.pattern("^[a-zA-Z0-9]{1,10}$")
      ]),
      q1: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
      q2: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
      q3: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
      q4: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
      q5: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
      q6: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
      q7: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
      q8: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
      q9: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
      q10: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
      q11: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
      q12: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
      qtd: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
      qgv: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
      qbth: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
      qtb: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
      qtp: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
      qbtn: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
      qpn: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
      qcc: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
      qhm: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
      qbc: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
      qnb: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
      qcg: new FormControl('', [
        Validators.required,
        Validators.pattern("^[1-9]+[0-9]{3,}$"),
      ]),
    })
  }

  onClickAdd() {
    if (this.customerFormGroup.get("name").invalid ||
      this.customerFormGroup.get("code").invalid ||
      this.customerFormGroup.get("q1").invalid ||
      this.customerFormGroup.get("q2").invalid ||
      this.customerFormGroup.get("q3").invalid ||
      this.customerFormGroup.get("q4").invalid ||
      this.customerFormGroup.get("q5").invalid ||
      this.customerFormGroup.get("q6").invalid ||
      this.customerFormGroup.get("q7").invalid ||
      this.customerFormGroup.get("q8").invalid ||
      this.customerFormGroup.get("q9").invalid ||
      this.customerFormGroup.get("q10").invalid ||
      this.customerFormGroup.get("q11").invalid ||
      this.customerFormGroup.get("q12").invalid ||
      this.customerFormGroup.get("qtd").invalid ||
      this.customerFormGroup.get("qgv").invalid ||
      this.customerFormGroup.get("qbth").invalid ||
      this.customerFormGroup.get("qtb").invalid ||
      this.customerFormGroup.get("qtp").invalid ||
      this.customerFormGroup.get("qbtn").invalid ||
      this.customerFormGroup.get("qpn").invalid ||
      this.customerFormGroup.get("qcc").invalid ||
      this.customerFormGroup.get("qhm").invalid ||
      this.customerFormGroup.get("qbc").invalid ||
      this.customerFormGroup.get("qnb").invalid ||
      this.customerFormGroup.get("qcg").invalid) {
      this.customerDataCreate.emit(CustomerType.Failed);
      return;
    }
    this.customerService.create(this.customer).subscribe(result => {
      this.customerDataCreate.emit(result);
      this.bsModalRef.hide();
    })
  }
}
