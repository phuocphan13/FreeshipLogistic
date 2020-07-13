import { NgModule } from "@angular/core";
import { ProductService } from "./product.service";
import { TestFlowService } from "./test-flow.service";

@NgModule({
    declarations: [
    ],
    providers: [
        ProductService,
        CustomerService,
        Bill_ShipperService,
    ]
})
export class ServiceModule { }
