import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShipperComponent } from './shipper.component';
import { ShipperRoutingModule } from './shipper-routing.module';

@NgModule({
  declarations: [
    ShipperComponent,
  ],
  imports: [
    CommonModule,
    ShipperRoutingModule,
  ],
  exports: [
    ShipperComponent
  ]
})
export class ShipperModule { }