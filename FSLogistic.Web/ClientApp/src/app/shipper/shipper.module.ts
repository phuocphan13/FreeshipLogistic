import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShipperBillComponent } from './shipper-bill/shipper-bill.component';
import { ShipperBillRoutingModule } from './shipper-bill/shipper-bill-routing.module';
import { ShipperComponent } from './shipper.component';
import { ShipperBillModule } from './shipper-bill/shipper-bill.module';
import { ShipperRoutingModule } from './shipper-routing.module';

@NgModule({
  declarations: [
    ShipperComponent,
  ],
  imports: [
    CommonModule,
    ShipperBillModule,
    ShipperRoutingModule,
  ],
  exports: [
    ShipperComponent,
    ShipperBillModule,
  ]
})
export class ShipperModule { }