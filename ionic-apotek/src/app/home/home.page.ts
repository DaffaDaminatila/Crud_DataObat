import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { ToastController } from '@ionic/angular';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';
@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage {
names: any;
  constructor(    
    private http: HttpClient,
    private toast: ToastController,
    private route: ActivatedRoute,
    private router: Router
  ) {
    this.route.params.subscribe((result: any) => {
      this.names = result.name;
      console.log(this.names);
    })
  }
  

  ClickDataObat(name) {
    this.router.navigate(['tab1/' + name]);
  }

  ClickDataSupplier(name) {
    this.router.navigate(['tab2/' + name]);
  }

  ClickDataTransaksi(name) {
    this.router.navigate(['tab3/' + name]);
  }
}
