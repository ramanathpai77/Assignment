import { Component, OnInit } from '@angular/core';
import { Product } from '../product';

@Component({
  selector: 'app-product-view',
  templateUrl: './product-view.component.html',
  styleUrls: ['./product-view.component.css']
})
export class ProductViewComponent implements OnInit {
list:Array<Product>;
prod:Product;
product:Product;
  constructor() {
    this.product={pid:null,pname:'',price:null,stock:null};
    this.prod=JSON.parse(localStorage.getItem("ndata"));
    
    this.product.pid=this.prod.pid;
    this.product.pname=this.prod.pname;
    this.product.price=this.prod.price;
    this.product.stock=this.prod.stock;
   }

  ngOnInit(): void {
  }

}
