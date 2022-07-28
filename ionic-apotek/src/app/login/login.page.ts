import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { ToastController } from '@ionic/angular';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-login',
  templateUrl: './login.page.html',
  styleUrls: ['./login.page.scss'],
})
export class LoginPage implements OnInit {
  public GETAdmin: any;
  username: string;
  password: string;

  constructor(
    private http: HttpClient,
    private toast: ToastController,
    private router: Router
  ) {}

  async toastController() {
    const toasts = await this.toast.create({
      message: 'Login Gagal. Username atau Password Salah',
      color: 'dark',
      position: 'top',
      duration: 2000,
    });
    toasts.present();
  }

  _GetDataAdmin() {
    let data: Observable<any>;
    if (this.username === null && this.password === null) {
      console.log('Error');
    } else {
      data = this.http.get(
        'http://localhost/Apotek3/api/Login/' +
          this.username +
          '/' +
          this.password
      );
      data.subscribe((result) => {
        this.GETAdmin = result;
        console.log(result.status);
        if (this.GETAdmin.status === 'Ok') {
          this.router.navigate(['/home']);
        } else {
          this.toastController();
        }
      });
    }
  }

  ngOnInit() {}
}
