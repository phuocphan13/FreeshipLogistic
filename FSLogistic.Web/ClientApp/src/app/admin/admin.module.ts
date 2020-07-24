import { NgModule, ɵAPP_ID_RANDOM_PROVIDER } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdminRoutingModule } from './admin-routing.module';
import { ShipperManagementModule } from './shipper-management/shipper-management.module';
import { AdminComponent } from './admin.component'
import { AdminBillModule } from './admin-bill/admin-bill.module';
import { CustomerManagementModule } from './customer-management/customer-management.module';

@NgModule({
  declarations: [
    AdminComponent
  ],
  imports: [
    CommonModule,
    ShipperManagementModule,
    AdminBillModule,
    AdminRoutingModule,
    CustomerManagementModule,
  ],
  exports: [
    AdminComponent,
    ShipperManagementModule,
    AdminBillModule,
    CustomerManagementModule,
  ]
})
export class AdminModule { }