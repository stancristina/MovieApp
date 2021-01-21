import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ApiService } from '../services/api.service';
import { Actor } from '../shared/actor.model';
import { Genre } from '../shared/genre.model';
import { Movie } from '../shared/movie.model';
import { MovieCast } from '../shared/movieCast.model';
import { MoviePremier } from '../shared/moviePremier.model';
import { Production } from '../shared/production.model';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.css']
})
export class AddComponent implements OnInit {
  addMovieForm: FormGroup;
  success: boolean;
  movies: Movie[];
  actors: Actor[];
  productions: Production[];
  genres: Genre[];

  constructor(public fb: FormBuilder, private api: ApiService, private router: Router) { }

  ngOnInit() {

    this.addMovieForm = this.fb.group({
      title: [null, Validators.required],
      description: [null, Validators.required],
      duration: [null, Validators.required],
      releaseDate: [null, Validators.required],
      premierDate: [null, Validators.required],
      premierLocation: [null, Validators.required],
      productionId: [-1, Validators.min(0)],
      actorIds: [-1, null],
      genreIds: [-1, null],

    });

    this.api.get<Actor>("actor/all").subscribe((data: Actor[]) => {
      this.actors = data;
      console.log(data);
    },
      (er: Error) => {
       console.log('err', er);
      });

    this.api.get<Genre>("genre/all").subscribe((data: Genre[]) => {
      this.genres = data;
      console.log(data);
    },
      (er: Error) => {
        console.log('err', er);
      });

    this.api.get<Production>("production/all").subscribe((data: Production[]) => {
      this.productions = data;
      console.log(data);
    },
      (er: Error) => {
        console.log('err', er);
      });
  }

  async add() {
    console.log(this.addMovieForm.value);
    var rawData = this.addMovieForm.value;
    /*this.api.post<Movie>("movie/create", createRequestPayload).subscribe((data) => {
      console.log(data);
    });*/

    // We have to insert Movie, MoviePremiere, MovieActors, MovieGenres

    var createPremierPayload = {
      'premierDate': rawData.premierDate,
      'premierLocation': rawData.premierLocation
    }

    // Step 1: Create a MoviePremier
    var moviePremierResponse = await this.api.post<MoviePremier>("moviepremier/create", createPremierPayload).toPromise();
    var moviePremierId = undefined;
    if (moviePremierResponse == null || moviePremierResponse.id == undefined) {
      console.log("Something wrong happened when creating movie premier");
      alert("Try again");
      return;
    }
    moviePremierId = moviePremierResponse.id;

    // Step 2: Create the movie
    var createMovieRequestPayload = {
      'title': rawData.title,
      'description': rawData.description,
      'duration': rawData.duration,
      'releaseDate': rawData.releaseDate,
      'moviePremierId': moviePremierId,
      'productionId': parseInt(rawData.productionId)
    }
    var movieCreateReponse = await this.api.post<Movie>("movie/create", createMovieRequestPayload).toPromise();
    if (movieCreateReponse == null || movieCreateReponse.id == undefined) {
      console.log("Something wrong happened when creating movie");
      alert("Try again");
      return;
    }

    // Step 3: Create movie cast mappings
    for (let i = 0; i < rawData.actorIds.length; i++) {
      var createMovieCastPayload = {
        "movieId": parseInt(movieCreateReponse.id),
        "actorId": parseInt(rawData.actorIds[i]),
        'role': 'standard',
        'revenue': 1499
      }
      var createMovieCastResponse = await this.api.post<MovieCast>("moviecast/create", createMovieCastPayload).toPromise();
      if (createMovieCastResponse == null || createMovieCastResponse.id == undefined) {
        console.log("Something wrong happened when creating movie cast: " + i);
        alert("Try again");
        return;
      }
    }

    // Step 4: Create movie genre mappings
    for (let i = 0; i < rawData.genreIds.length; i++) {
      var createMovieGenrePayload = {
        "movieId": parseInt(movieCreateReponse.id),
        "genreId": parseInt(rawData.actorIds[i])
      }
      var createMovieGenreResponse = await this.api.post<MovieCast>("moviegenre/create", createMovieGenrePayload).toPromise();
      if (createMovieGenreResponse == null || createMovieGenreResponse.id == undefined) {
        console.log("Something wrong happened when creating movie genre: " + i);
        alert("Try again");
        return;
      }
    }

    alert('Movie created succesfully');
    this.router.navigate(['/']);
  }
}

