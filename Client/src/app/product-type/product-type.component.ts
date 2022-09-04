import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ProducttypeService } from '../services/producttype.service';

@Component({
  selector: 'app-product-type',
  templateUrl: './product-type.component.html',
  styleUrls: ['./product-type.component.scss']
})
export class ProductTypeComponent implements OnInit {

  constructor(private productTypeService: ProducttypeService) { }
  ProductType: any;
  ngOnInit(): void {
    this.onPageLoadGetProductTypeData();
  }

  onPageLoadGetProductTypeData() {
    this.productTypeService.getProductType().subscribe((response) => {
      this.ProductType = response;
      console.log(this.ProductType,'this.product')
    }, (error) => {
      console.log(error);
    })
  }

}
