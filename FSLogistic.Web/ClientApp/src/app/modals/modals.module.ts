import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { AppCommonModule } from '../common/app-common.module';
import { AddCustomerModalComponent } from './add-customer-modal/add-customer-modal.component';
import { UpdateCustomerModalComponent } from './update-customer-modal/update-customer-modal.component';

@NgModule({
    declarations: [
        AddCustomerModalComponent,
        UpdateCustomerModalComponent,
    ],
    imports: [
        FormsModule,
        CommonModule,
        AppCommonModule,
        ReactiveFormsModule,
    ],
    providers: [
    ],
    entryComponents: [
        AddCustomerModalComponent,
        UpdateCustomerModalComponent,
    ],
    exports: [
        AddCustomerModalComponent,
        UpdateCustomerModalComponent,
    ]
})
export class ModalsModule { }
