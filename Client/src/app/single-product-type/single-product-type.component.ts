import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { HomeService } from '../services/home.service';

@Component({
  selector: 'app-single-product-type',
  templateUrl: './single-product-type.component.html',
  styleUrls: ['./single-product-type.component.scss']
})
export class SingleProductTypeComponent implements OnInit {
  productType: any;
  constructor(private route:ActivatedRoute,private router:Router,private Homeservice:HomeService) { }

  ngOnInit(): void {

    this.route.paramMap.subscribe((param) => {
      var id = Number(param.get('id'));
      console.log(id, 'SingleProductTypeComponent id id id ');
      this.getById(id);
    })

  }

  getById(id: number) {
    this.Homeservice.getProductByTypeId(id).subscribe((response) => {
      console.log(response,'dataaa')
      this.productType = response;
    });
  }
}
