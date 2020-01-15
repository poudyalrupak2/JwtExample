import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import { FormsModule} from '@angular/forms';
import { AppComponent } from './app.component';
import { HotelComponent } from './hotel/hotel.component';
import { NavComponent } from './nav/nav.component';
import { AuthserviceService } from './_services/authservice.service';
@NgModule({
   declarations: [
      AppComponent,
      HotelComponent,
      NavComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      FormsModule
   ],
   providers: [
      AuthserviceService


   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
