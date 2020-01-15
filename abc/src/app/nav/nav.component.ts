import { Component, OnInit } from '@angular/core';
import { AuthserviceService } from '../_services/authservice.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};

  constructor( private authservice: AuthserviceService) { }

  ngOnInit() {
  }
login(){
  this.authservice.login(this.model).subscribe(next =>{
console.log('logged in successfully')
  }, error => {
console.log(error);
  }  );

}
}
