import { Routes, RouterModule } from "@angular/router";
import { NgModule } from "@angular/core";
import { ShipperComponent } from "./shipper.component";
import { AuthorizeGuard } from "src/api-authorization/authorize.guard";
import { ShipperBillComponent } from "./shipper-bill/shipper-bill.component";

const routes: Routes = [
    {
        path: 'shipper',
        component: ShipperComponent,
        children: [
            {
                path: 'bill',
                component: ShipperBillComponent,
            },
        ]
    }
];

@NgModule({
    imports: [
        RouterModule.forChild(routes)
    ],
    entryComponents: [
        ShipperComponent,
    ],
    exports: [
        RouterModule
    ],
    providers: [
    ]
})

export class ShipperRoutingModule { }
