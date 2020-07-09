import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdminBillComponent } from './admin-bill.component';
import { AdminBillDatashowingComponent } from './admin-bill-datashowing/admin-bill-datashowing.component';
import { AdminBillRoutingModule } from './admin-bill-routing.module';
import { ToolbarAdminComponent } from './toolbar-admin/toolbar-admin.component';
import { FormsModule } from '@angular/forms';
import { NgSelectModule } from '@ng-select/ng-select';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';

@NgModule({
  declarations: [
    AdminBillComponent,
    AdminBillDatashowingComponent,
    ToolbarAdminComponent,
  ],
  imports: [
    CommonModule,
    AdminBillRoutingModule,
    FormsModule,
    NgSelectModule,    
    BsDatepickerModule.forRoot(),
  ],
  exports: [
    AdminBillComponent
  ]
})
export class AdminBillModule { }