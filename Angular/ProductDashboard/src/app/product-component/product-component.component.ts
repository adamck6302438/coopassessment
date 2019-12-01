import { Component, OnInit } from '@angular/core';
import { ProductService} from '../service/ProductService';

//Reference: https://www.techiediaries.com/angular-tutorial-example-rest-api-httpclient-get-ngfor/

@Component({
  selector: 'app-product-component',
  templateUrl: './product-component.component.html',
  styleUrls: ['./product-component.component.css']
})
export class ProductComponentComponent implements OnInit {

  constructor(private productService: ProductService) { }

  ngOnInit() {
    
  }

}
