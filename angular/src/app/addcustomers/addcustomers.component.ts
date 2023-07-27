import { Component , OnInit } from '@angular/core';
import { ShipService } from '../ship.service';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-addcustomers',
  templateUrl: './addcustomers.component.html',
  styleUrls: ['./addcustomers.component.css']
})
export class AddcustomersComponent {

  public addgrp!:FormGroup;

  constructor(private build:FormBuilder, private api: ShipService){}
  ngOnInit(): void {  
    this.addgrp=this.build.group({ 
    cname:[],
    product:[],
    weight:[],
    source:[],
    destination:[],
    ship:[],
  });

  }
  

private init():void{

}

public addbtn():void
{
  this.api.AddCustomers(this.addgrp.value).subscribe(res=>{
    this.addgrp = res;
    
  })
}
}
