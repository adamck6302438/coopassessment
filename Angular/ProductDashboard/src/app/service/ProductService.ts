import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import { Product } from '../Product';
import { Observable, of, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  //base api url
  public url = 'http://localhost:4201/api/products';
  constructor(private http: HttpClient) { }

  getProducts(id: number) : Observable<Product>{
    const requestURL = '${url}/${id}'
    return this.http.get<Product>(requestURL);
  }

  getAllProducts() : Observable<Product[]>{
    return this.http.get<Product[]>(this.url);
  }

  editProduct(id: number, product: Product) : Observable<any>{
    const requestURL = '${url}/${id}';
    return this.http.put(requestURL, product);
  }

  deleteProduct(id: number) : Observable<Product>{
    const requestURL = '${url}/${id}';
    return this.http.delete<Product>(requestURL);
  }

  addProduct(product: Product): Observable<Product>{
    return this.http.post<Product>(this.url, product);
  }
}