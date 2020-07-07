import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShipperBillComponent } from './shipper-bill.component';
import { ShipperBillRoutingModule } from './shipper-bill-routing.module';
import { ShipperBillDatashowingComponent } from './shipper-bill-datashowing/shipper-bill-datashowing.component';

@NgModule({
  declarations: [
    ShipperBillComponent,
    ShipperBillDatashowingComponent,
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