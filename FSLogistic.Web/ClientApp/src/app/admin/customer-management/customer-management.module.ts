import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CustomerManagementComponent } from './customer-management.component';
import { CustomerManagementRoutingModule } from './customer-management-routing.module';
import { CustomerManagementDatashowingComponent } from './customer-management-datashowing/customer-management-datashowing.component';
import { CustomerManagementToolbarComponent } from './customer-management-toolbar/customer-management-toolbar.component';

@NgModule({
  declarations: [
    CustomerManagementComponent,
    CustomerManagementDatashowingComponent,
    CustomerManagementToolbarComponent
  ],
  imports: [
    CommonModule,
    CustomerManagementRoutingModule
  ],
  exports: [
    CustomerManagementComponent,
  ]
})
export class CustomerManagementModule { }