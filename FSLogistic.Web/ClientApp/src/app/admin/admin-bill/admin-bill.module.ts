import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdminBillComponent } from './admin-bill.component';
import { AdminBillDatashowingComponent } from './admin-bill-datashowing/admin-bill-datashowing.component';
import { AdminBillRoutingModule } from './admin-bill-routing.module';
import { FormsModule } from '@angular/forms';
import { NgSelectModule } from '@ng-select/ng-select';
import { PipeModule } from 'src/app/common/pipes/pipe.module';

@NgModule({
  declarations: [
    AdminBillComponent,
    AdminBillDatashowingComponent,
  ],
  imports: [
    CommonModule,
    AdminBillRoutingModule,
    FormsModule,
    NgSelectModule,    
    PipeModule,
  ],
  exports: [
    AdminBillComponent
  ]
})
export class AdminBillModule { }