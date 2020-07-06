import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdminBillComponent } from './admin-bill.component';
import { AdminBillDatashowingComponent } from './admin-bill-datashowing/admin-bill-datashowing.component';
import { AdminBillRoutingModule } from './admin-bill-routing.module';

@NgModule({
  declarations: [
AdminBillComponent,
AdminBillDatashowingComponent,
  ],
  imports: [
    CommonModule,
    AdminBillRoutingModule,
  ],
  exports: [
    AdminBillComponent
  ]
})
export class AdminBillModule { }