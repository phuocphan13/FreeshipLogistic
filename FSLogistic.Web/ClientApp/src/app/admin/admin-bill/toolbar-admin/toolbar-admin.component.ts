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
    { id: 1, name: 'Tìm kiếm theo ngày' },
    { id: 2, name: 'Tìm kiếm theo trạng thái' },
    { id: 3, name: 'Tìm kiếm theo tên khách hàng' },
    { id: 4, name: 'Tìm kiếm theo tên nhân viên' },
  ];

  constructor() { }

  ngOnInit() {
  }

}
