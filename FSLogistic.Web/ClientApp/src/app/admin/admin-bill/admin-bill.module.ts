import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdminBillComponent } from './admin-bill.component';
import { AdminBillRoutingModule } from './admin-bill-routing.module';

@NgModule({
  declarations: [
    AdminBillComponent,
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