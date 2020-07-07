import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShipperBillComponent } from './shipper-bill.component';
import { ShipperBillRoutingModule } from './shipper-bill-routing.module';

@NgModule({
  declarations: [
    ShipperBillComponent,
  ],
  imports: [
    CommonModule,
    ShipperBillRoutingModule,
  ],
  exports: [
    ShipperBillComponent,
  ]
})
export class ShipperBillModule { }