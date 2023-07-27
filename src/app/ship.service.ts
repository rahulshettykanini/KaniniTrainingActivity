import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs'

@Injectable({
  providedIn: 'root'
})
export class ShipService {

  //private basepath = "https://localhost:7183";

  constructor(private http:HttpClient) { }

  public GetShips():Observable<any>
  {
  
    return this.http.get("https://localhost:7183/api/Ships");
  }

  public GetCustomers():Observable<any>
  {
  
    return this.http.get("https://localhost:7183/api/Customers");
  }

  public  delbyId(id:string):Observable<any>{
    return this.http.delete("https://localhost:7183/api/Ships/"+id);
  }

  public  delCustbyId(id:string):Observable<any>{
    return this.http.delete("https://localhost:7183/api/Customers/"+id);
  }


  public AddShips(shiplist:any):Observable<any>
  {
    return this.http.post("https://localhost:7183/api/Ships", shiplist);
  }

  public AddCustomers(shiplist:any):Observable<any>
  {
    return this.http.post("https://localhost:7183/api/Customers", shiplist);
  }

  public update(id:string,updatedCar:any):Observable<any>
  {
    let url=("https://localhost:7183/api/Ships/" + id);
    return this.http.put(url, updatedCar);
  }

  public updateCustomers(id:string,updatedCar:any):Observable<any>
  {
    let url=("https://localhost:7183/api/Customers/" + id);
    return this.http.put(url, updatedCar);
  }

}