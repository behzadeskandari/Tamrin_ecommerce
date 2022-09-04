import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { HomeService } from '../services/home.service';

@Component({
  selector: 'app-single-product-brand',
  templateUrl: './single-product-brand.component.html',
  styleUrls: ['./single-product-brand.component.scss']
})
export class SingleProductBrandComponent implements OnInit {
  ProductBrand: any;
  constructor(private route:ActivatedRoute,private router:Router,private Homeservice:HomeService) { }

  ngOnInit(): void {

    this.route.paramMap.subscribe((param) => {
      var id = Number(param.get('id'));
      console.log(id, 'SingleProductBrandComponent id id id ');
      this.getById(id);
    })

  }

  getById(id: number) {
    this.Homeservice.getProductByBrandId(id).subscribe((response) => {
      console.log(response,'dataaa')
      this.ProductBrand = response;
    });
  }

}
