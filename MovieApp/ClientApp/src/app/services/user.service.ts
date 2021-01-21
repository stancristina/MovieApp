import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { User } from '../_models';

@Injectable({ providedIn: 'root' })
export class UserService {
  constructor(private http: HttpClient) { }

  getAll() {
    return this.http.get<User[]>(`/users`);
  }

  register({username, password}) {
    console.log(username, password);
    return this.http.post(`/api/auth/register`, {username, password});
  }

  delete(id: number) {
    return this.http.delete(`/users/${id}`);
  }
}
