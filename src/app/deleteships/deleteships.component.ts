import { Component } from '@angular/core';
import { ShipService } from '../ship.service';
import { IShips } from '../models/Ships';


@Component({
  selector: 'app-deleteships',
  templateUrl: './deleteships.component.html',
  styleUrls: ['./deleteships.component.css']
})
export class DeleteshipsComponent {
  
  constructor(private api:ShipService){}
  carId!:string;
  name? : IShips;
    delbtn():void
    {
      /*console.log('hi')
      this.api.delbyId(this.carId).subscribe(res=>{
        alert('Deleted');
        return 
      });*/
      return this.api.delbyId(this.carId).subscribe(data=>this.name=data),alert(" deleted successfully");
    }
}
