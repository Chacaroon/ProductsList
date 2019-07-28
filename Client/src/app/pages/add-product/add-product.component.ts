import { Component, OnInit } from '@angular/core';
import { CategoryService } from '../../services/category/category.service';
import { Category } from '../../models/category';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ProductService } from '../../services/product/product.service';
import { AddProduct } from '../../models/addProduct';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.scss']
})
export class AddProductComponent implements OnInit {

  categories: Category[];
  form: FormGroup;

  constructor(private categoryService: CategoryService,
              private productService: ProductService,
              private fb: FormBuilder) {
  }

  ngOnInit() {
    this.form = this.fb.group({
      name: ['', Validators.required],
      categoryId: [0, Validators.min(1)]
    });

    this.categoryService.getAll()
      .subscribe(res => this.categories = res);
  }

  submit() {
    if (!this.form.valid) return;

    const {name, categoryId} = this.form.value;

    this.productService.addProduct(new AddProduct(name, categoryId));
  }
}
