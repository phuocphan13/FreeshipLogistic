import { Routes, RouterModule } from "@angular/router";
import { NgModule } from "@angular/core";
import { ShipperBillComponent } from "./shipper-bill.component";
import { ShipperBillDatashowingComponent } from "./shipper-bill-datashowing/shipper-bill-datashowing.component";

const routes: Routes = [
    {
        path: 'bill',
        component: ShipperBillComponent,
        children: [
            {
                path: '',
                component: ShipperBillDatashowingComponent,
            },
        ]
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