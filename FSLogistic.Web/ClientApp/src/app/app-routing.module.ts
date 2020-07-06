import { Routes, RouterModule } from "@angular/router";
import { NgModule } from "@angular/core";
import { AuthorizeGuard } from "src/api-authorization/authorize.guard";
const appRoutes: Routes = [
    {
        path: 'shipper',
        canActivate: [AuthorizeGuard],
        loadChildren: './shipper/shipper.module#ShipperModule'
    },
    {

        path: 'admin',
        canActivate: [AuthorizeGuard],
        loadChildren: './admin/admin.module#AdminModule'
    },
];

@NgModule({
    imports: [
        RouterModule.forRoot(appRoutes)
    ],
    providers: [
    ],
    exports: [
        RouterModule
    ]
})

export class AppRoutingModule { }