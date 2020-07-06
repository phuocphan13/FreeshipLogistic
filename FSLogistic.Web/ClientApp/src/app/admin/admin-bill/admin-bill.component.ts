import { Component, OnInit } from '@angular/core';
import { Router, RouterModule } from "@angular/router";

@Component({
  selector: 'app-admin-bill',
  templateUrl: './admin-bill.component.html',
  styleUrls: ['./admin-bill.component.scss']
})
export class AdminBillComponent implements OnInit {

  constructor(private route:Router) { }

  ngOnInit() {
  }

}
