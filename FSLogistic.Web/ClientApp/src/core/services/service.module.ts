import { NgModule } from "@angular/core";
import { ProductService } from "./product.service";
import { CustomerService } from "./customer.service";
import { Bill_ShipperService } from "./bill_shipper.service";

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
