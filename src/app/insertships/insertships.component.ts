import { Component, OnInit } from '@angular/core';
import { ShipService } from '../ship.service';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-insertships',
  templateUrl: './insertships.component.html',
  styleUrls: ['./insertships.component.css']
})
export class InsertshipsComponent implements OnInit {
  public addgrp!:FormGroup;

  constructor(private build:FormBuilder, private api: ShipService){}
  ngOnInit(): void {  
    this.addgrp=this.build.group({ 
    sname:[],
    capacity:[],
    starting:[],
    ending:[],
    price:[],
    
  });

  }
  

private init():void{

}

public addbtn():void
{
  this.api.AddShips(this.addgrp.value).subscribe(res=>{
    this.addgrp = res;
    
  })
}
}
