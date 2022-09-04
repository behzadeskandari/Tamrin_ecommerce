import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class BrandtypeService {

  constructor(private http: HttpClient) { }

  baseUrl = "https://localhost:5001/api/ProductBrand";

  getBrandType() {
    return this.http.get(this.baseUrl);
  }

  getBrandTypeById(value :Number) {
    return this.http.get(this.baseUrl+'/'+ value)
  }
}
