import { Injectable } from '@angular/core';
import {CanActivate, Router, ActivatedRouteSnapshot } from '@angular/router';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';
import { routerNgProbeToken } from '@angular/router/src/router_module';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private authService: AuthService, private router: Router, private aleritfy: AlertifyService) {}
  canActivate(next: ActivatedRouteSnapshot): boolean {
  const temProles = next.firstChild.data.roles as Array<string>;
  if (temProles) {
  const match =  this.authService.roleMatch(temProles);
  if (match) {
    return true;
  } else {
    this.router.navigate(['home']);
    this.aleritfy.error('You are not authorized to view this area');
  }}
  if (this.authService.loggedIn()) {
      return true;
    }
  this.aleritfy.error('you shall not pass');
  this.router.navigate(['/home']);
  return false;
  }
}
