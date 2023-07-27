import { Component } from '@angular/core';
import { ShipService } from '../ship.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-updateships',
  templateUrl: './updateships.component.html',
  styleUrls: ['./updateships.component.css']
})
export class UpdateshipsComponent {
  carlist:any={sname :'', capacity :'', starting :'',  ending : '', price :''}

 
  constructor(private api: ShipService, private router: Router) {
    
  }
  carId!:string
  public UpdateCarById(){
    console.log(56458)
    return this.api.update(this.carId ,this.carlist)
    .subscribe( result =>
      {
        // result=this.prdtlist
        alert("updated")
      }
      );
  }
}
