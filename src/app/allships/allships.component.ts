import { Component, OnInit } from '@angular/core';
import { ShipService } from '../ship.service';

@Component({
  selector: 'app-allships',
  templateUrl: './allships.component.html',
  styleUrls: ['./allships.component.css']
})
export class AllshipsComponent implements OnInit{

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
