import { Component, OnInit } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-add-customer-modal',
  templateUrl: './add-customer-modal.component.html',
  styleUrls: ['./add-customer-modal.component.scss']
})
export class AddCustomerModalComponent implements OnInit {

  constructor(private bsModalRef:BsModalRef,) { }

  ngOnInit() {
  }

  onClickCancel() {
    this.bsModalRef.hide();
  }

  onClickAdd(){
  }
}
