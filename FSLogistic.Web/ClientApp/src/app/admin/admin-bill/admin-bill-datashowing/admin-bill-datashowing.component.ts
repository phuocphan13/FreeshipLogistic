import { Component, OnInit } from '@angular/core';
import { AdminService } from 'src/core/services/admin.service';
import { AdminBillModel } from 'src/core/models/admin-bill.model';
import { ResponeStatusEnum } from 'src/core/models/shared/respone.model';
import { BsModalService, BsModalRef, ModalOptions } from 'ngx-bootstrap/modal';
import { AddBillModalComponent } from 'src/app/modals/add-bill-modal/add-bill-modal.component';

@Component({
  selector: 'app-admin-bill-datashowing',
  templateUrl: './admin-bill-datashowing.component.html',
  styleUrls: ['./admin-bill-datashowing.component.scss']
})
export class AdminBillDatashowingComponent implements OnInit {
  listbills: AdminBillModel[] = [];
  modalRef: BsModalRef;
  config: ModalOptions = { class: 'modal-lg' };
  
  statusId: any;
  pickedStatus: any;

  listStatus: any = [
    { id: 1, name: 'Tìm kiếm theo ngày' },
    { id: 2, name: 'Tìm kiếm theo trạng thái' },
    { id: 3, name: 'Tìm kiếm theo tên khách hàng' },
    { id: 4, name: 'Tìm kiếm theo tên nhân viên' },
  ];

  constructor(private adminService: AdminService,
              private bsModalService: BsModalService) { }

  ngOnInit() {
    this.adminService.get().subscribe(result => {
      if (result.responeStatus == ResponeStatusEnum.Successed) {
        this.listbills = result.data;
      }
    })
  }

  onClickAdd(){
    this.modalRef = this.bsModalService.show(AddBillModalComponent, this.config)
  }
}
