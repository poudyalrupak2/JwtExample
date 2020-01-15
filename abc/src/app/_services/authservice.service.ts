import { Injectable } from '@angular/core';
import { logging } from 'protractor';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
@Injectable({
  providedIn: 'root'
})
export class AuthserviceService {
baseurl = "http://localhost:5000/api/";
constructor(private http: HttpClient) { }
login(model: any){
  return this.http.post(this.baseurl + 'Auth/Authenticate', model)
  .pipe(
    map((response: any) => {
      const user = response;
      if (user) {
        localStorage.setItem('token', user.tokenString);
      }
    }
)
  )
}



}
