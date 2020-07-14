import { Component, OnInit } from '@angular/core';
import { Router } from "@angular/router";
import { Product } from "../product";
import { FormsModule } from '@angular/forms';
@Component({
  selector: 'app-product-add',
  templateUrl: './product-add.component.html',
  styleUrls: ['./product-add.component.css']
})
export class ProductAddComponent implements OnInit {
  item:Product;
  

  constructor(private router:Router) {
    this.item={pid:'',pname:'',price:'',stock:''}
        
   }

  ngOnInit(): void {
  }
  addProduct()
  {
    localStorage.setItem("ndata",JSON.stringify(this.item));
    this.router.navigateByUrl('productview')
    }
    cleanTemp()
    {
      this.item={pid:'',pname:'',price:'',stock:''};
    }

  }


