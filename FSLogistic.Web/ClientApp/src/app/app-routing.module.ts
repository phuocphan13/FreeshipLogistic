import { Routes, RouterModule } from "@angular/router";
import { NgModule } from "@angular/core";
const appRoutes: Routes = [
    {
        path: 'shipper',
        loadChildren: './shipper/shipper.module#ShipperModule'
    },
    {
        path: 'admin',
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