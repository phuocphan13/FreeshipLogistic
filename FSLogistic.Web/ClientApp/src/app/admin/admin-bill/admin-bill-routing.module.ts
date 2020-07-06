import { Routes, RouterModule } from "@angular/router";
import { NgModule } from "@angular/core";
import { AdminBillComponent } from "./admin-bill.component";

const routes: Routes = [
    {
        path: 'bill',
        component: AdminBillComponent,
    },
];

@NgModule({
    imports: [
        RouterModule.forChild(routes)
    ],
    entryComponents: [
        AdminBillComponent,
    ],
    exports: [
        RouterModule
    ],
    providers: [
    ]
})

export class AdminBillRoutingModule { }