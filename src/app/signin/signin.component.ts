import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-signin',
  templateUrl: './signin.component.html',
  styleUrls: ['./signin.component.css']
})
export class SigninComponent {
  constructor(private route:Router){}
emailid! :string;
roles! :string;
password! : string;

  signin() {
    if(this.password=="Rahul123"){
      if(confirm('login successfully'))
      {
        this.route.navigate(['/admin']);
      }
    }
  
    }

}
