import { NgModule } from "@angular/core";
import { ProductService } from "./product.service";
import { CustomerService } from "./customer.service";
import { Bill_ShipperService } from "./bill_shipper.service";
import { AdminService } from "./admin.service";
import { ShipperService } from "./shipper.service";
import { ShipperManagementService } from "./shipper-management.service";

@NgModule({
    declarations: [
    ],
    providers: [
        ProductService,
        CustomerService,
        ShipperService,
        AdminService,
        ShipperManagementService,
    ]
})
export class ServiceModule { }
