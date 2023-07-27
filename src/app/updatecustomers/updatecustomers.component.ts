import { Component } from '@angular/core';
import { ShipService } from '../ship.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-updatecustomers',
  templateUrl: './updatecustomers.component.html',
  styleUrls: ['./updatecustomers.component.css']
})
export class UpdatecustomersComponent {

  carlist:any={cname :'', product :'', weight :'',  source : '', destination :'', ship : ''}

 
  constructor(private api: ShipService, private router: Router) {
    
  }
  carId!:string
  public UpdateCarById(){
    console.log(56458)
    return this.api.updateCustomers(this.carId ,this.carlist)
    .subscribe( result =>
      {
        // result=this.prdtlist
        alert("updated")
      }
      );
  }

}
