import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShipperBillComponent } from './shipper-bill.component';
import { ShipperBillRoutingModule } from './shipper-bill-routing.module';
import { ShipperBillDatashowingComponent } from './shipper-bill-datashowing/shipper-bill-datashowing.component';
import { FormsModule } from '@angular/forms';
import { NgSelectModule } from '@ng-select/ng-select';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';
import { pipe } from 'rxjs';
import { MycurrencyPipe } from 'src/app/common/pipes/my-currency-pipe';
import { PipeModule } from 'src/app/common/pipes/pipe.module';


@NgModule({
  declarations: [
    ShipperBillComponent,
    ShipperBillDatashowingComponent,
  ],
  imports: [
    CommonModule,
    ShipperBillRoutingModule,
    FormsModule,
    NgSelectModule,    
    BsDatepickerModule.forRoot(),
    PipeModule,
  ],
  exports: [
    ShipperBillComponent,
  ]
})
export class ShipperBillModule { }