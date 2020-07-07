import { Routes, RouterModule } from "@angular/router";
import { NgModule } from "@angular/core";
import { ShipperBillComponent } from "./shipper-bill.component";

const routes: Routes = [
    {
        path: 'bill',
        component: ShipperBillComponent,
        
    },
];

@NgModule({
    imports: [
        RouterModule.forChild(routes)
    ],
    entryComponents: [
        ShipperBillComponent,
    ],
    exports: [
        RouterModule
    ],
    providers: [
    ]
})

export class ShipperBillRoutingModule { }