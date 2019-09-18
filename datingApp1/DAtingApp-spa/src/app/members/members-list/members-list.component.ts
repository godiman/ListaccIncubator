import { Component, OnInit } from '@angular/core';
import { AlertifyService } from '../../_services/alertify.service';
import { UserService } from '../../_services/User.service';
import { User } from '../../modules/user';
import { ActivatedRouteSnapshot, ActivatedRoute } from '@angular/router';
import { Pagination, PaginatedResult } from 'src/app/modules/Pagination';
import { Subject } from 'rxjs';
import { debounceTime, distinctUntilChanged, switchMap } from 'rxjs/operators';

@Component({
  selector: 'app-members-list',
  templateUrl: './members-list.component.html',
  styleUrls: ['./members-list.component.css']
})
export class MembersListComponent implements OnInit {
  users: User[];
  pagination: Pagination;
  userParam: any = {};
  private searchTerms = new Subject<string>();
  user: User = JSON.parse(localStorage.getItem('user'));
  genderList = [{value: 'male', display: 'Males'}, {value: 'female', display: 'Females'}];
  constructor(private alertify: AlertifyService, private userService: UserService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.route.data.subscribe(data => {
      this.users = data.users.result;
      this.pagination = data.users.pagination;
    });
    this.userParam.gender = this.user.gender === 'female' ? 'male' : 'female';
    this.userParam.minAge = 18;
    this.userParam.maxAge  = 99;
    this.userParam.searchTerm = '';

    this.searchTerms.pipe(
      // wait 300ms after each keystroke before considering the term
      debounceTime(2000),
      // ignore new term if same as previous term
      distinctUntilChanged(),
      // switch to new search observable each time the term changes
      switchMap((searchTerm: string) => {
        this.userParam.searchTerm = searchTerm;
        return this.userService
      .getUsers(this.pagination.currentPage, this.pagination.itemsPerPage, this.userParam); }
      ),
    ).subscribe((res) => {
      this.users = res.result;
      this.pagination = res.pagination;
      console.log(this.pagination);
    },
    error => {
      this.alertify.error(error);
    });
  }

    search(term: string) {
      this.searchTerms.next(term);
    }
  pageChanged(event: any): void {
    this.pagination.currentPage = event.page;
    this.loadUsers();
  }

  resetFilters() {
    this.userParam.gender = this.user.gender === 'female' ? 'male' : 'female';
    this.userParam.minAge = 18;
    this.userParam.maxAge  = 99;
    this.loadUsers();
  }

  loadUsers() {
   this.userService.getUsers(this.pagination.currentPage, this.pagination.itemsPerPage, this.userParam)
   .subscribe((res: PaginatedResult<User[]>) => {
      this.users = res.result;
      this.pagination = res.pagination;
    },
    error => {
      this.alertify.error(error);
    });
  }
}
