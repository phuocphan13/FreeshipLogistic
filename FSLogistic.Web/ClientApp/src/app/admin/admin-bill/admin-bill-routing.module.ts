import { Routes, RouterModule } from "@angular/router";
import { NgModule } from "@angular/core";
import { AdminBillComponent } from "./admin-bill.component";
import { AdminBillDatashowingComponent } from "./admin-bill-datashowing/admin-bill-datashowing.component";

const routes: Routes = [
    {
        path: 'bill',
        component: AdminBillComponent,
        children:[
            {
                path:'',
                component:AdminBillDatashowingComponent,
            },
        ]
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