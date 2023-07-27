import { Component ,OnInit} from '@angular/core';
import { ShipService } from '../ship.service';
@Component({
  selector: 'app-allcustomers',
  templateUrl: './allcustomers.component.html',
  styleUrls: ['./allcustomers.component.css']
})
export class AllcustomersComponent {

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
