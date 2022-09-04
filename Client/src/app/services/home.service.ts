import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class HomeService {

  constructor(private http: HttpClient) { }

  baseUrl = "https://localhost:5001/api/Product";

  getProducts() {
    return this.http.get(this.baseUrl);
  }

  getProductsById(value :number) {
    return this.http.get(this.baseUrl+'/'+ value)
  }

  getProductByTypeId(id : number) {
    return this.http.get(this.baseUrl + `/type/${id}`)
  }

  getProductByBrandId(id : number) {
    return this.http.get(this.baseUrl + `/brand/${id}`)
  }
}
