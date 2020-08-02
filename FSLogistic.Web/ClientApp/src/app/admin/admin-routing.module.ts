import { Routes, RouterModule } from "@angular/router";
import { NgModule } from "@angular/core";
import { AdminComponent } from "./admin.component";
import { AdminBillComponent } from "./admin-bill/admin-bill.component";
import { ShipperManagementComponent } from "./shipper-management/shipper-management.component";
import { CustomerManagementComponent } from "./customer-management/customer-management.component";

const routes: Routes = [
    {
        path: 'admin',
        component: AdminComponent,
        children:[
            {
                path:'bill',
                component:AdminBillComponent,
            },
            {
                path:'shipper-management',
                component:ShipperManagementComponent,
            },
            {
                path:'customer-management',
                component:CustomerManagementComponent,
            },
        ]
    },
];

@NgModule({
    imports: [
        RouterModule.forChild(routes)
    ],
    entryComponents: [
        AdminComponent,
    ],
    exports: [
        RouterModule
    ],
    providers: [
    ]
})

export class AdminRoutingModule { }