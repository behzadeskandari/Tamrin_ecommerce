import { Component, OnInit } from '@angular/core';
import { BrandtypeService } from '../services/brandtype.service';

@Component({
  selector: 'app-brand-type',
  templateUrl: './brand-type.component.html',
  styleUrls: ['./brand-type.component.scss']
})
export class BrandTypeComponent implements OnInit {
  BrandType: any;
  constructor(private BrandTypeservice: BrandtypeService) { }

  ngOnInit(): void {
    this.onPageLoadGetBrandTypeData();
  }

  onPageLoadGetBrandTypeData() {
    this.BrandTypeservice.getBrandType().subscribe((response) => {
      this.BrandType = response;
      console.log(this.BrandType,'this.product')
    }, (error) => {
      console.log(error);
    })
  }

}
