import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShipperManagementComponent } from './shipper-management.component';
import { ShipperManagementDatashowingComponent } from './shipper-management-datashowing/shipper-management-datashowing.component';
import { ShipperManagementRoutingModule } from './shipper-management-routing.module';

@NgModule({
  declarations: [
    ShipperManagementDatashowingComponent,
    ShipperManagementComponent,
  ],
  imports: [
    CommonModule,
    ShipperManagementRoutingModule,
  ],
  exports: [
    ShipperManagementComponent
  ]
})
export class ShipperManagementModule { }