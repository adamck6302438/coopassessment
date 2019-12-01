import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ProductComponentComponent } from './product-component/product-component.component';
import { AddProductComponentComponent } from './product-component/add-product-component/add-product-component.component';

@NgModule({
  declarations: [
    AppComponent,
    NewsComponent,
    ProductComponentComponent,
    AddProductComponentComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
