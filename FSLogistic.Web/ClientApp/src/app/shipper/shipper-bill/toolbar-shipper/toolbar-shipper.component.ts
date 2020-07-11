import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-toolbar-shipper',
  templateUrl: './toolbar-shipper.component.html',
  styleUrls: ['./toolbar-shipper.component.scss']
})
export class ToolbarShipperComponent implements OnInit {

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

  constructor() { }

  ngOnInit() {
  }

}
