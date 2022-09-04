import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProducttypeService {

  constructor(private http: HttpClient) { }

  baseUrl = "https://localhost:5001/api/ProductType";

  getProductType() {
    return this.http.get(this.baseUrl);
  }

  getProductTypeById(value :Number) {
    return this.http.get(this.baseUrl+'/'+ value)
  }
}
