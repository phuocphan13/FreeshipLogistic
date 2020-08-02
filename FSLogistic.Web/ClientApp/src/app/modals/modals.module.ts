import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
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
        AppCommonModule,
        ReactiveFormsModule,
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
