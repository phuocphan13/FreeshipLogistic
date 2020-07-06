import { Routes, RouterModule } from "@angular/router";
import { NgModule } from "@angular/core";
import { AuthorizeGuard } from "src/api-authorization/authorize.guard";
import { ShipperManagementComponent } from "./shipper-management.component";

const routes: Routes = [
    {
        path: 'shipper-management',
        component: ShipperManagementComponent,
    },
];

@NgModule({
    imports: [
        RouterModule.forChild(routes)
    ],
    entryComponents: [
        ShipperManagementComponent,
    ],
    exports: [
        RouterModule
    ],
    providers: [
    ]
})

export class ShipperManagementRoutingModule { }