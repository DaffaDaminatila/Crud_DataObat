import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


@Component({
  selector: 'app-tab4',
  templateUrl: './tab4.page.html',
  styleUrls: ['./tab4.page.scss'],
})
export class Tab4Page implements OnInit {

  public GETAdmin: any;

  constructor(   
    private http: HttpClient
    ) {}

    ionViewWillEnter() {
      this._GetData();
    }
  
    _GetData() {
      let data: Observable<any>;
      data = this.http.get('http://localhost/Apotek3/api/GetDataAdmin');
      data.subscribe(result => {
        this.GETAdmin= result;
        console.log(result);
      });
    }
  ngOnInit() {
  }

}
