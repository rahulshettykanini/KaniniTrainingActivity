import { Component, OnInit } from '@angular/core';
import { ShipService } from '../ship.service';

@Component({
  selector: 'app-seecustomers',
  templateUrl: './seecustomers.component.html',
  styleUrls: ['./seecustomers.component.css']
})
export class SeecustomersComponent  {

  public students: any;
  constructor(private service: ShipService) { }

  ngOnInit(): void {
    this.GetAllCustomers();
  }

  private GetAllCustomers(): void {
    this.service.GetCustomers().subscribe(result => {
      this.students = result;
      console.log(this.students);
    });
  }


}
