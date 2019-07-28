import { Component, OnInit } from '@angular/core';
import { ProductService } from '../../services/product/product.service';
import { Product } from '../../models/product';
import { PageChangedEvent } from 'ngx-bootstrap';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent implements OnInit {

  products: Product[];
  productsCount: number;

  constructor(private productService: ProductService) {
  }

  ngOnInit() {
    this.productService.products.subscribe(res => {
      this.products = res.products;
      this.productsCount = res.productsCount;
    });

    this.productService.updateProductsList();
  }

  pageChanged(event: PageChangedEvent) {
    this.productService.updateProductsList(event.page);
  }
}
