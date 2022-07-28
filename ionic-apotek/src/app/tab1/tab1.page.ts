import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { HttpClient } from '@angular/common/http';
import { ToastController } from '@ionic/angular';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-tab1',
  templateUrl: 'tab1.page.html',
  styleUrls: ['tab1.page.scss']
})
export class Tab1Page {
public names: any;
  public GETObat: any;

  constructor(   
    private http: HttpClient,
    private toast: ToastController,
    private route: ActivatedRoute
    ) {
      this.route.params.subscribe((result: any) => {
        this.names = result.name;
        console.log(this.names);
      })
    }

    ionViewWillEnter() {
      this._GetData();
    }
  
    _GetData() {
      let data: Observable<any>;
      data = this.http.get('http://localhost/Apotek3/api/GetDataObat');
      data.subscribe(result => {
        this.GETObat= result;
        console.log(result);
      });
    }
 
  
}
