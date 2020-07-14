import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProductAddComponent } from "./product-add/product-add.component";
import { ProductViewComponent } from "./product-view/product-view.component";

const routes: Routes = [
  {path:'addproduct',component:ProductAddComponent},
  {path:'viewproduct',component:ProductViewComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
