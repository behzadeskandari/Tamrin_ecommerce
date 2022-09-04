import { i18nMetaToJSDoc } from '@angular/compiler/src/render3/view/i18n/meta';
import { Component, OnDestroy, OnInit } from '@angular/core'
import { HomeService } from '../services/home.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit, OnDestroy {
  HomeProducts : any;
  days: string[]=["Sunday", "Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"]
  constructor(private Homeservice:HomeService) { }

  ngOnInit(): void {
    this.onPageLoadGetProductData();
  }

  onPageLoadGetProductData() {
    this.Homeservice.getProducts().subscribe((response) => {
      this.HomeProducts = response;
      console.log(this.HomeProducts,'home products')

      console.log(response);
    }, (err) => {

    })
  }

  ngOnDestroy(): void {
    //Called once, before the instance is destroyed.
    //Add 'implements OnDestroy' to the class.

  }
}
