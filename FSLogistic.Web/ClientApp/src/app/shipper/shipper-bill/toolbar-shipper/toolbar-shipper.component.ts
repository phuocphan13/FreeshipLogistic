import { Component, OnInit} from '@angular/core';

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
    { id: 1, name: 'Rồi' },
    { id: 2, name: 'Chưa' },
    { id: 3, name: 'Chuyển hoàn' },
  ];

  constructor() { }

  ngOnInit() {
  }

}
