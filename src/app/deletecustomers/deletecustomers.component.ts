import { Component } from '@angular/core';
import { ShipService } from '../ship.service';
import { ICustomers } from '../models/Ships';

@Component({
  selector: 'app-deletecustomers',
  templateUrl: './deletecustomers.component.html',
  styleUrls: ['./deletecustomers.component.css']
})
export class DeletecustomersComponent {

  constructor(private api:ShipService){}
  carId!:string;
  name? : ICustomers;
    delbtn():void
    {
      /*console.log('hi')
      this.api.delbyId(this.carId).subscribe(res=>{
        alert('Deleted');
        return 
      });*/
      return this.api.delCustbyId(this.carId).subscribe(data=>this.name=data),alert(" deleted successfully");
    }

}
