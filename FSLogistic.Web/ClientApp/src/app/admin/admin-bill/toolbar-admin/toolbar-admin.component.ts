import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-toolbar-admin',
  templateUrl: './toolbar-admin.component.html',
  styleUrls: ['./toolbar-admin.component.scss']
})
export class ToolbarAdminComponent implements OnInit {

  statusId: any;
  pickedStatus: any;

  listStatus: any = [
    { id: 1, name: 'Rồi' },
    { id: 2, name: 'Chưa' },
    { id: 3, name: 'Chuyển hoàn' },
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

  staffId: any;
  pickedStaff: any;

  listStaff: any = [
    { id: 1, name: 'HoangQ2' },
    { id: 2, name: 'KhanhBC' },
    { id: 3, name: 'UyenQ10' },
    { id: 4, name: 'ToanQ12' },
    { id: 5, name: 'ThoTD' },
    { id: 6, name: 'MinhQ11' },
  ]
  constructor() { }

  ngOnInit() {
  }

}
