import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Product } from 'src/core/models/product.model';
import { ProductService } from 'src/core/services/product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  public products: Product[];

  constructor(private productService: ProductService) {
  }

  ngOnInit() {
    this.productService.get().subscribe(result => {
      this.products = result;
      console.log(this.products);
    },
      error => console.error(error))
  }

}
