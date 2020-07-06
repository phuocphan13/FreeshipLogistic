import { Routes, RouterModule } from "@angular/router";
import { NgModule } from "@angular/core";
import { AuthorizeGuard } from "src/api-authorization/authorize.guard";
import { AdminComponent } from "./admin.component";
import { AdminBillComponent } from "./admin-bill/admin-bill.component";
import { ShipperManagementComponent } from "./shipper-management/shipper-management.component";

const routes: Routes = [
    {
        path: 'admin',
        canActivateChild: [AuthorizeGuard],
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