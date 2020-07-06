import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdminRoutingModule } from './admin-routing.module';
import { ShipperManagementModule } from './shipper-management/shipper-management.module';
import { AdminComponent } from './admin.component'

@NgModule({
  declarations: [
    AdminComponent,
  ],
  imports: [
    CommonModule,
    ShipperManagementModule,
    AdminRoutingModule,
  ],
  exports: [
    AdminComponent,
    ShipperManagementModule,
  ]
})
export class AdminModule { }