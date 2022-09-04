import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.scss']
})
export class NavComponent implements OnInit {
  navigationbool : boolean= true;
  constructor(private router:Router) { }

  ngOnInit(): void {
    // if (window.innerWidth >= 374) {
    //   this.navigationbool = true;
    // } else {
    //   this.navigationbool = false;
    // }
  }

  NavigationToggle() {
    if (window.innerWidth >= 374) {
      this.navigationbool = true;
    } else {
      this.navigationbool = !this.navigationbool
    }

  }
  NavigateToRegister() {
    this.router.navigateByUrl('/register')
  }

  NavigateToLogin() {
    this.router.navigateByUrl('/login');
  }

}
