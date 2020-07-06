import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdminRoutingModule } from './admin-routing.module';
import { ShipperManagementModule } from './shipper-management/shipper-management.module';
import { AdminComponent } from './admin.component'
import { AdminBillModule } from './admin-bill/admin-bill.module';

@NgModule({
  declarations: [
    AdminComponent,
  ],
  imports: [
    CommonModule,
    ShipperManagementModule,
    AdminBillModule,
    AdminRoutingModule,
  ],
  exports: [
    AdminComponent,
    ShipperManagementModule,
    AdminBillModule,
  ]
})
export class AdminModule { }