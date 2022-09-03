import { AppComponent } from './app.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BrandTypeComponent } from './brand-type/brand-type.component';
import { ProductTypeComponent } from './product-type/product-type.component';
import { ContactusComponent } from './contactus/contactus.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  { path: 'ProductType', component: ProductTypeComponent },
  { path: 'contactus', component: ContactusComponent },
  { path: 'BrandType', component: BrandTypeComponent },
  { path: '', component: HomeComponent },
  { path: '**', component: HomeComponent }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
