import { SingleproductComponent } from './singleproduct/singleproduct.component';
import { AppComponent } from './app.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BrandTypeComponent } from './brand-type/brand-type.component';
import { ProductTypeComponent } from './product-type/product-type.component';
import { ContactusComponent } from './contactus/contactus.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { SingleProductTypeComponent } from './single-product-type/single-product-type.component';
import { SingleProductBrandComponent } from './single-product-brand/single-product-brand.component';

const routes: Routes = [
  { path: 'ProductType', component: ProductTypeComponent },
  { path: 'BrandType', component: BrandTypeComponent },
  { path: 'ProductType/:id', component: SingleProductTypeComponent },
  { path: 'Product/:id', component: SingleproductComponent },


  { path: 'BrandType/:id', component: SingleProductBrandComponent },
  { path: 'contactus', component: ContactusComponent },
  { path: 'login', component: LoginComponent },
  { path: 'register' ,component: RegisterComponent },
  { path: '', component: HomeComponent },
  { path: '**', component: HomeComponent }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
