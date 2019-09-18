import { Injectable } from '@angular/core';
import {environment} from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { User } from '../modules/user';

@Injectable({
  providedIn: 'root'
})
export class AdminService {
baseUrl = environment.Url;
constructor(private http: HttpClient) { }
getUsersWithroles() {
  return this.http.get(this.baseUrl + 'admin/usersWithRoles');
 }

 updateUserRoles(user: User, roles: {}) {
   return this.http.post(this.baseUrl + 'admin/editRoles' + user.username, roles);
}
}
