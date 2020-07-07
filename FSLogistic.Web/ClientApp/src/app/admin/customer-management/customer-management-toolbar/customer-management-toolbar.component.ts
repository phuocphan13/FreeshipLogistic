import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-customer-management-toolbar',
  templateUrl: './customer-management-toolbar.component.html',
  styleUrls: ['./customer-management-toolbar.component.scss']
})
export class CustomerManagementToolbarComponent implements OnInit {

  constructor() { }

  combobox:any =[
    "Code","Name","Dist"
  ];

  ngOnInit() {
  }

  onClickCreate(){
  }
}
