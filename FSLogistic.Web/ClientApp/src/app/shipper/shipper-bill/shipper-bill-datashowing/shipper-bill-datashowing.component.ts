import { Component, OnInit } from '@angular/core';
import { ResponeStatusEnum } from 'src/core/models/shared/respone.model';
import { ShipperService } from 'src/core/services/shipper.service';
import { ShipperBillModel } from 'src/core/models/shipper-bill.model';

@Component({
  selector: 'app-shipper-bill-datashowing',
  templateUrl: './shipper-bill-datashowing.component.html',
  styleUrls: ['./shipper-bill-datashowing.component.scss']
})
export class ShipperBillDatashowingComponent implements OnInit {
  
  listbills: ShipperBillModel[] = [];

  searchString: string;
  showingId: number;

  statusId: any;
  pickedStatus: any;

  listStatus: any = [
    { id: 1, name: 'Tìm kiếm theo ngày' },
    { id: 2, name: 'Tìm kiếm theo trạng thái' },
    { id: 3, name: 'Tìm kiếm theo tên khách hàng' },
  ];

  customerId: any;
  pickedCustomer: any;

  listCustomer: any = [
    { id: 1, name: 'NguyenThu' },
    { id: 2, name: 'KhoGaChiBuoi' },
    { id: 3, name: 'LeMinh' },
    { id: 4, name: 'MyTra' },
    { id: 5, name: 'UyenBetty' },
    { id: 6, name: 'ThanhVy' },
  ];

  constructor(private shipperService: ShipperService) { }

  ngOnInit() {
    this.shipperService.get().subscribe(result => {
      if (result.responeStatus == ResponeStatusEnum.Successed) {
        this.listbills = result.data;
        console.log(result);
      }
    })
  }

  onClickEdit() {

  }
}
