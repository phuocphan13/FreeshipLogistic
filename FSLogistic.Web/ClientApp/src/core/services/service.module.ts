import { NgModule } from "@angular/core";
import { ProductService } from "./product.service";
import { TestFlowService } from "./test-flow.service";
import { CustomerService } from "./customer.service";

@NgModule({
    declarations: [
    ],
    providers: [
        ProductService,
        TestFlowService,
        CustomerService
    ]
})
export class ServiceModule { }