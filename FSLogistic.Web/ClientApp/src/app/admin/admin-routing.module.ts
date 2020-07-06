import { Routes, RouterModule } from "@angular/router";
import { NgModule } from "@angular/core";
import { AdminComponent } from "./admin.component";

const routes: Routes = [
    {
        path: 'admin',
        component: AdminComponent,
    },
];

@NgModule({
    imports: [
        RouterModule.forChild(routes)
    ],
    entryComponents: [
        AdminComponent,
    ],
    exports: [
        RouterModule
    ],
    providers: [
    ]
})

export class AdminRoutingModule { }