import { Component} from '@angular/core';

import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


@Component({
  selector: 'app-tab3',
  templateUrl: './tab3.page.html',
  styleUrls: ['./tab3.page.scss'],
})
export class Tab3Page{

  public names: any;
  public GETTransaksi: any;

  constructor(   
    private http: HttpClient
    ) {}

    ionViewWillEnter() {
      this._GetData();
    }
  
    _GetData() {
      let data: Observable<any>;
      data = this.http.get('http://localhost/Apotek3/api/GetDataTransaksi');
      data.subscribe(result => {
        this.GETTransaksi= result;
        console.log(result);
      });
    }
}
