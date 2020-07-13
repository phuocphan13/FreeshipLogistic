import { NgModule } from "@angular/core";
import { ProductService } from "./product.service";
import { TestFlowService } from "./test-flow.service";
import { ShipperManagementService } from "./shipper-management.service";

@NgModule({
    declarations: [
    ],
    providers: [
        ProductService,
        TestFlowService,
        ShipperManagementService,
    ]
})
export class ServiceModule { }