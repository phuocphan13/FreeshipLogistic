import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CustomerManagementComponent } from './customer-management.component';
import { CustomerManagementRoutingModule } from './customer-management-routing.module';
import { CustomerManagementDatashowingComponent } from './customer-management-datashowing/customer-management-datashowing.component';
import { PipeModule } from 'src/app/common/pipes/pipe.module';
import { NgSelectModule } from '@ng-select/ng-select';
import { FormsModule } from '@angular/forms';
import { NgbCollapseModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({
  declarations: [
    CustomerManagementComponent,
    CustomerManagementDatashowingComponent,
  ],
  imports: [
    CommonModule,
    CustomerManagementRoutingModule,
    PipeModule,
    NgSelectModule,
    FormsModule,
    NgbCollapseModule,
  ],
  exports: [
    CustomerManagementComponent,
  ]
})
export class CustomerManagementModule { }
