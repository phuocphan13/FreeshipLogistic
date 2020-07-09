import { Component, OnInit } from '@angular/core';
import { ShipperManagementService } from 'src/core/services/shipper-management.service';

@Component({
  selector: 'app-shipper-management-datashowing',
  templateUrl: './shipper-management-datashowing.component.html',
  styleUrls: ['./shipper-management-datashowing.component.scss']
})
export class ShipperManagementDatashowingComponent implements OnInit {

  constructor(private shipperManagementService: ShipperManagementService) { }
  listShipper:any[];
  ngOnInit() {
    this.shipperManagementService.get().subscribe(result=>{
      if (result)
      {
        console.log(result);
        this.listShipper=result.data;
      }
    })
  }

}
