import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-hotel',
  templateUrl: './hotel.component.html',
  styleUrls: ['./hotel.component.css']
})
export class HotelComponent implements OnInit {

  hotels: any;
   constructor(private http: HttpClient){


   }

  ngOnInit() {
    this.getHotels();
  }
  getHotels(){
    this.http.get('http://localhost:5000/api/hotel').subscribe(response => {
      this.hotels = response;
      console.log(response);
    }, error => {
      console.log(error);
    });
  }
}
