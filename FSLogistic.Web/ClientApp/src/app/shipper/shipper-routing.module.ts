import { Routes, RouterModule } from "@angular/router";
import { NgModule } from "@angular/core";
import { ShipperComponent } from "./shipper.component";
import { AuthorizeGuard } from "src/api-authorization/authorize.guard";

const routes: Routes = [
    {
        path: 'shipper',
        component: ShipperComponent, 
        canActivateChild: [AuthorizeGuard],     
    }
];

@NgModule({
    imports: [
        RouterModule.forChild(routes)
    ],
    exports: [
        RouterModule
    ],
    providers: [
    ]
})

export class ShipperRoutingModule { }