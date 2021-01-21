import { Component, OnInit, ViewChild } from '@angular/core';
import { Movie } from '../shared/movie.model';
import { ApiService } from '../services/api.service';
import { AuthenticationService } from '../services';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  movies: Movie[] = [];
  searchText: string;
  title: string;
  isUserLoggedIn: boolean = false; 

  constructor(private api: ApiService,
    private authenticationService: AuthenticationService) {

    if (this.authenticationService.currentUserValue) {
      this.isUserLoggedIn = true;
    }

    this.authenticationService.currentUser.subscribe(data => {
      if (data == null) {
        this.isUserLoggedIn = false;
        this.movies = [];
        this.ngOnInit();

      } else {
        this.isUserLoggedIn = true;
        this.ngOnInit();
      }
    });

  }

  ngOnInit() {


    if (!this.isUserLoggedIn) {
      this.movies = [];
      return;
    }
    this.api.get<Movie>("movie/all").subscribe((data: Movie[]) => {
      this.movies = data;
    },
      (er: Error) => {
        console.log('err', er);
      });
  }

  
  }
