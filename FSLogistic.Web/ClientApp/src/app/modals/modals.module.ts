import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { AppCommonModule } from '../common/app-common.module';
import { AddCustomerModalComponent } from './add-customer-modal/add-customer-modal.component';

@NgModule({
    declarations: [
        AddCustomerModalComponent,
    ],
    imports: [
        FormsModule,
        CommonModule,
        AppCommonModule
    ],
    providers: [
    ],
    entryComponents: [
        AddCustomerModalComponent,
    ],
    exports: [
        AddCustomerModalComponent,
    ]
})
export class ModalsModule { }
