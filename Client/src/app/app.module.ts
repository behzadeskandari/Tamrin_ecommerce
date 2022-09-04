import { NgModule } from '@angular/core';

import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';

import {HttpClientModule} from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ProductTypeComponent } from './product-type/product-type.component';
import { BrandTypeComponent } from './brand-type/brand-type.component';
import { NavComponent } from './nav/nav.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { CommonModule } from '@angular/common';
import {HomeComponent } from './home/home.component';
import { SingleProductTypeComponent } from './single-product-type/single-product-type.component';
import { SingleProductBrandComponent } from './single-product-brand/single-product-brand.component';
import { SingleproductComponent } from './singleproduct/singleproduct.component';
import { FooterComponent } from './footer/footer.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductTypeComponent,
    BrandTypeComponent,
    NavComponent,
    LoginComponent,
    RegisterComponent,
    HomeComponent,
    SingleProductTypeComponent,
    SingleProductBrandComponent,
    SingleproductComponent,
    FooterComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    CommonModule,
    FormsModule,
    NgbModule
  ],
  providers: [],

  bootstrap: [AppComponent]
})
export class AppModule { }
