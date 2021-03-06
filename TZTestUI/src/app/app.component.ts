import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpErrorResponse } from '@angular/common/http';


interface Locker{
  name:String;
  size:Number;
}
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.sass']
})
export class AppComponent {
  title = 'TZTest';
  constructor (private httpService: HttpClient) { }
  arrLockers: string [];
  arrLockersVal:Locker[];

  columnsCount: Number;

  columns: any[] = [];

  apiUrl:string='http://localhost:51063/api/values';
  

 

  
  ngOnInit () {
    this.httpService.get(this.apiUrl).subscribe(
      data => {
        this.arrLockers = data['columns'] as string [];	 // FILL THE ARRAY WITH DATA.
        //  console.log(this.arrLockers[0]);
      
        Object.entries(this.arrLockers).map( res => {
          this.columns.push(res[1])

          this.columnsCount= this.columns.length;
          
        });

        console.log(this.columns);
      },
      (err: HttpErrorResponse) => {
        console.log (err.message);
      }
    );
  }

}
