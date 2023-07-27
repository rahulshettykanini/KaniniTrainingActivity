import { Component, OnInit } from '@angular/core';
import { ShipService } from '../ship.service';

@Component({
  selector: 'app-seeships',
  templateUrl: './seeships.component.html',
  styleUrls: ['./seeships.component.css']
})
export class SeeshipsComponent implements OnInit{

  public students: any;
  constructor(private service: ShipService) { }

  ngOnInit(): void {
    this.GetAllShips();
  }

  private GetAllShips(): void {
    this.service.GetShips().subscribe(result => {
      this.students = result;
      console.log(this.students);
    });
  }

}
