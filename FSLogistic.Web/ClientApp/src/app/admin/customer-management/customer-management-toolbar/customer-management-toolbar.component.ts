import { Component, OnInit } from '@angular/core';
import { BsModalService, BsModalRef, ModalOptions } from 'ngx-bootstrap/modal';
import { AddCustomerModalComponent } from 'src/app/modals/add-customer-modal/add-customer-modal.component';

@Component({
  selector: 'app-customer-management-toolbar',
  templateUrl: './customer-management-toolbar.component.html',
  styleUrls: ['./customer-management-toolbar.component.scss']
})
export class CustomerManagementToolbarComponent implements OnInit {

  constructor(private bsModalService: BsModalService,) { }
  modalRef: BsModalRef

  config: ModalOptions = { class: 'modal-lg' };

  combobox: any = [
    "Code", "Name", "Dist"
  ];

  ngOnInit() {
  }

  onClickCreate() {
    this.modalRef = this.bsModalService.show(AddCustomerModalComponent, this.config)
  }
}
