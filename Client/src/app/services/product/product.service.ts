import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { ProductsList } from '../../models/products-list';
import { Observable, Subject } from 'rxjs';
import { environment } from '../../../environments/environment';
import { AddProduct } from '../../models/addProduct';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private productsListSubject: Subject<ProductsList>;

  constructor(private http: HttpClient,
              private router: Router) {
    this.productsListSubject = new Subject<ProductsList>();
  }

  public get products(): Observable<ProductsList> {
    return this.productsListSubject.asObservable();
  }

  public updateProductsList(page: number = 1): void {
    this.http.get<ProductsList>(`${environment.apiUri}/Products`, {
      params: new HttpParams()
        .append('page', page.toString())
    })
      .subscribe(res => this.productsListSubject.next(res));
  }

  public addProduct(product: AddProduct): void {
    this.http.post(`${environment.apiUri}/Products`, product)
      .subscribe(_ => this.router.navigate(['']));
  }
}
