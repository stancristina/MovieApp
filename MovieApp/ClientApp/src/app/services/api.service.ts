import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Actor } from '../shared/actor.model';
import { Genre } from '../shared/genre.model';
import { Movie } from '../shared/movie.model';
import { Production } from '../shared/production.model';
import { MoviePremier } from '../shared/moviePremier.model';
import { Observable } from 'rxjs/internal/Observable';


@Injectable({
  providedIn: 'root'
})
export class ApiService {


  constructor(private http: HttpClient) {}

  header = new HttpHeaders({
    'Content-Type': 'application/json'
  });
  baseUrl = 'https://localhost:44341/api/';
 
  get<T>(path: string, params: {} = {}): Observable<any> {
    return this.http.get<T>(this.baseUrl + path, { params });
  }

  post<T>(path: string, body: object = {}): Observable<any> {
    return this.http.post<T>(this.baseUrl + path, body);
  }

  put<T>(path: string, body: object = {}): Observable<any> {
    return this.http.put<T>(this.baseUrl + path, body);
  }

  delete<T>(path: string): Observable<any> {
    return this.http.delete<T>(this.baseUrl + path);
  }
}


