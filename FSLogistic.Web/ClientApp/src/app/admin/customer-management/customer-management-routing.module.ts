import { Routes, RouterModule } from "@angular/router";
import { NgModule } from "@angular/core";
import { AuthorizeGuard } from "src/api-authorization/authorize.guard";
import { CustomerManagementComponent } from "./customer-management.component";
import { CustomerManagementDatashowingComponent } from "./customer-management-datashowing/customer-management-datashowing.component";

const routes: Routes = [
    {
        path: 'customer-management',
        component: CustomerManagementComponent,
        children:[
            {
                path:'',
                component:CustomerManagementDatashowingComponent,
            }
        ]
    },
];

@NgModule({
    imports: [
        RouterModule.forChild(routes)
    ],
    entryComponents: [
        CustomerManagementComponent,
    ],
    exports: [
        RouterModule
    ],
    providers: [
    ]
})

export class CustomerManagementRoutingModule { }