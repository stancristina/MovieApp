import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthenticationService } from '../services';


@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  constructor(
    private router: Router,
    private authenticationService: AuthenticationService
  ) {
    // add subscriber to use observer
    if (this.authenticationService.currentUserValue) {
      this.isUserLoggedIn = true;
    }
    this.authenticationService.currentUser.subscribe(data => {
      if (data == null) {
        this.isUserLoggedIn = false;
      } else {
        this.isUserLoggedIn = true;
      }
    });
  }

  isUserLoggedIn = false;
  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  logoutUser() {
    this.authenticationService.logout();
    this.router.navigate(['/']);
  }

}
