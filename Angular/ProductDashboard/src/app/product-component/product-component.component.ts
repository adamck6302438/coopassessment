import { Component, OnInit } from '@angular/core';
import { ProductService} from '../service/ProductService';
import { Product } from '../Product';

//Reference: https://www.techiediaries.com/angular-tutorial-example-rest-api-httpclient-get-ngfor/

@Component({
  selector: 'app-product-component',
  templateUrl: './product-component.component.html',
  styleUrls: ['./product-component.component.css']
})
export class ProductComponentComponent implements OnInit {

  displayedColumns: string[] = ['product_id','product_name', 'price', 'product_description'];
  data: Product[] = [];
  constructor(private productService: ProductService) { }

  ngOnInit() {
    
    this.productService.getAllProducts()
    .subscribe(res => {
      this.data = res;
      console.log(this.data);
    })
  }

}
