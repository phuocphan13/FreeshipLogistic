import { Component, OnInit } from '@angular/core';
import { Customer } from 'src/core/models/customer.model';
import { CustomerService } from 'src/core/services/customer.service';
import { ResponeStatusEnum } from 'src/core/models/shared/respone.model';
import { BsModalRef, BsModalService, ModalOptions } from 'ngx-bootstrap/modal';
import { AddCustomerModalComponent } from 'src/app/modals/add-customer-modal/add-customer-modal.component';

@Component({
  selector: 'app-customer-management-datashowing',
  templateUrl: './customer-management-datashowing.component.html',
  styleUrls: ['./customer-management-datashowing.component.scss'],
})
export class CustomerManagementDatashowingComponent implements OnInit {
  listCustomers: Customer[] = [];

  modalRef:BsModalRef;
  config: ModalOptions = { class: 'modal-lg' };

  listStatus: any = [
    { id: 1, name: 'Tìm kiếm theo tên' },
    { id: 2, name: 'Tìm kiếm theo mã' },
    { id: 3, name: 'Tìm kiếm theo quận' },
  ];
  
  constructor(private customerService: CustomerService,
    private bsModalService:BsModalService,
  ) { }

  ngOnInit() {
    this.customerService.get().subscribe(result => {
      console.log(result);
      if (result.responeStatus == ResponeStatusEnum.Successed) {
        this.listCustomers = result.data;
      }
    })
  }

  onClickCreate() {
    this.modalRef = this.bsModalService.show(AddCustomerModalComponent, this.config)
  }
}
