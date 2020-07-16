import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShipperManagementComponent } from './shipper-management.component';
import { ShipperManagementDatashowingComponent } from './shipper-management-datashowing/shipper-management-datashowing.component';
import { ShipperManagementRoutingModule } from './shipper-management-routing.module';
import { NgSelectModule } from '@ng-select/ng-select';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    ShipperManagementDatashowingComponent,
    ShipperManagementComponent,
  ],
  imports: [
    CommonModule,
    NgSelectModule,
    FormsModule,
    ReactiveFormsModule,
    ShipperManagementRoutingModule,
  ],
  exports: [
    ShipperManagementComponent
  ]
})
export class ShipperManagementModule { }