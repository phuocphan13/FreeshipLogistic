import { Component, OnInit } from '@angular/core';
import { ShipperManagementService } from 'src/core/services/shipper-management.service';
import { ShipperDataModel } from '../../../../core/models/shipper-data.model';

@Component({
  selector: 'app-shipper-management-datashowing',
  templateUrl: './shipper-management-datashowing.component.html',
  styleUrls: ['./shipper-management-datashowing.component.scss']
})
export class ShipperManagementDatashowingComponent implements OnInit {

  constructor(private shipperManagementService: ShipperManagementService) { }
  listShipper: ShipperDataModel[]=[];
  ngOnInit() {
    this.shipperManagementService.get().subscribe(result => {
      if (result.data) {
        this.listShipper = result.data;
      }
    })
  }
}
