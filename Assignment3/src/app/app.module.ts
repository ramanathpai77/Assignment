import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmpViewComponent } from './emp-view/emp-view.component';

@NgModule({
  declarations: [
    AppComponent,
    EmpViewComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  
  bootstrap: [EmpViewComponent]
})
export class AppModule { }
