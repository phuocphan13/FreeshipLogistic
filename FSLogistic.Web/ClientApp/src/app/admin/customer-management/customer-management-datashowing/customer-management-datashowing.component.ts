import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Customer } from 'src/core/models/customer.model';
import { CustomerService } from 'src/core/services/customer.service';
import { ResponeStatusEnum } from 'src/core/models/shared/respone.model';
import { BsModalRef, BsModalService, ModalOptions } from 'ngx-bootstrap/modal';
import { AddCustomerModalComponent } from 'src/app/modals/add-customer-modal/add-customer-modal.component';
import { UpdateCustomerModalComponent } from 'src/app/modals/update-customer-modal/update-customer-modal.component';
import { AlertMessageService } from 'src/core/services/alert-message.service';
import { AlertService } from 'ngx-alerts';
import { CustomerType } from 'src/app/common/customer-enum';

@Component({
  selector: 'app-customer-management-datashowing',
  templateUrl: './customer-management-datashowing.component.html',
  styleUrls: ['./customer-management-datashowing.component.scss'],
})
export class CustomerManagementDatashowingComponent implements OnInit {

  isExpand: boolean = false;
  detailText: string = "Xem ＋";

  listCustomers: Customer[] = [];
  listCustomersShow: Customer[] = [];

  statusId: any;

  searchData: any;

  listCustomersSearch: Customer[] = [];

  modalRef: BsModalRef;
  config: ModalOptions = {
    class: 'modal-lg',
    ignoreBackdropClick: true
  };

  listStatus: any = [
    { id: 1, name: 'Tìm kiếm theo tên' },
    { id: 2, name: 'Tìm kiếm theo mã' },
  ];

  constructor(private customerService: CustomerService,
    private bsModalService: BsModalService,
    private alertMessageService: AlertMessageService,
    private alertService: AlertService,
  ) { }

  ngOnInit() {
    this.customerService.get().subscribe(result => {
      if (result.responeStatus == ResponeStatusEnum.Successed) {
        this.listCustomers = result.data;
        this.listCustomersShow = this.listCustomers;
        this.alertService.success("Tải dữ liệu thành công!!")
      }
      else {
        this.alertService.danger("Tải dữ liệu thất bại!!")
      }
    })
  }

  onClickCreate() {
    this.modalRef = this.bsModalService.show(AddCustomerModalComponent, this.config);
    this.modalRef.content.customerDataCreate.subscribe(result => {
      if (result.responeStatus == ResponeStatusEnum.Successed) {
        this.listCustomers.push(result.data);
        this.listCustomersShow = this.listCustomers;
        this.alertService.success("Thêm Thành Công!!");
      }
      if (result == CustomerType.Failed) {
        this.alertService.danger("Sai định dạng hoặc chưa điền đủ dữ liệu");
      }
    });
  }

  onClickEdit(i: any) {
    this.modalRef = this.bsModalService.show(UpdateCustomerModalComponent, this.config);
    this.modalRef.content.customer = this.listCustomers[i];
    this.modalRef.content.customerDataEdit.subscribe(result => {
      if (result.responeStatus == ResponeStatusEnum.Successed) {
        this.alertService.success("Sửa Thành Công!!");
      }
      if (result == CustomerType.Failed) {
        this.alertService.danger("Sai định dạng hoặc chưa điền đủ dữ liệu");
      }
      if (result == CustomerType.NotChange) {
        this.alertService.danger("Dữ liệu không thay đổi, vui lòng kiểm tra lại trước khi cập nhật.")
      }
    });
  }

  onClickCollapse(i: any) {
    this.isExpand = !this.isExpand;
    document.getElementsByClassName("hover-collapse").item(i).innerHTML = this.isExpand ? "Đóng －" : "Xem ＋";
  }
}
