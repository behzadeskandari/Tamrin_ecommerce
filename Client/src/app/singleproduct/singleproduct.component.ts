import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap, Router } from '@angular/router';
import { HomeService } from '../services/home.service';

@Component({
  selector: 'app-singleproduct',
  templateUrl: './singleproduct.component.html',
  styleUrls: ['./singleproduct.component.scss']
})
export class SingleproductComponent implements OnInit {

  constructor(private homeService: HomeService,private route:ActivatedRoute,private router:Router) { }
  singleProductData : any;
  ProductArr: [] = [];
  ngOnInit(): void {

    this.route.paramMap.subscribe((param: ParamMap) => {
      var id = Number(param.get('id'));
      console.log(id, 'SingleproductComponent id id id ');
      this.getById(id);
    })

  }

  getById(id: number) {
    this.homeService.getProductsById(id).subscribe((response) => {
      console.log(response,'dataaa')
      this.singleProductData = response
      // this.ProductArr.push(this.singleProductData)
      console.log(this.singleProductData,'singleProductData singleProductData')
    });
  }
}
