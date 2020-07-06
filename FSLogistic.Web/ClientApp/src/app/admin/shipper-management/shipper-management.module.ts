import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShipperManagementComponent } from './shipper-management.component';
import { ShipperManagementRoutingModule } from './shipper-management-routing.module';

@NgModule({
  declarations: [
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