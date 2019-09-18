import { Component, OnInit } from '@angular/core';
import { AdminService } from 'src/app/_services/admin.service';
import { User } from 'src/app/modules/user';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { BsModalRef, BsModalService } from 'ngx-bootstrap';
import { RolesModalComponent } from '../../roles-modal/roles-modal.component';
import { mergeResolvedReflectiveProviders } from '@angular/core/src/di/reflective_provider';

@Component({
  selector: 'app-user-management',
  templateUrl: './user-management.component.html',
  styleUrls: ['./user-management.component.css']
})
export class UserManagementComponent implements OnInit {
  users: User[];
  bsModalRef: BsModalRef;
  constructor(private adminService: AdminService, private alertifyService: AlertifyService,
              public modalService: BsModalService) { }

  ngOnInit() {
    this.getUsersWithRoles();
  }

  getUsersWithRoles() {
    this.adminService.getUsersWithroles().subscribe((data: User[]) => { this.users = data;
    },
    error => { console.log(error);
               this.alertifyService.error(error);
    }
    );
  }

  editRolesModal(user: User) {
    const initialState = {
      user,
      roles: this.getRolesArray(user),
      title: user.username + '\'s User Roles'
    };
    this.bsModalRef = this.modalService.show(RolesModalComponent, {initialState});
    this.bsModalRef.content.closeBtnName = 'Close';
    this.bsModalRef.content.updateSelectedRoles.subscribe(
      (values) => {
        const rolesToUpdate = {
          roleNames: [...values.filter(el => el.checked === true).map(el => el.name)]
        };
        console.log(rolesToUpdate);
      });
    console.log('inside editRolesModal');
  }

  getRolesArray(user: User) {
    const roles = [];
    const userRoles =  user.roles;
    const availableRoles: any[] = [
      {name: 'Admin', value: 'Admin'},
      {name: 'Moderator', value: 'Moderator'},
      {name: 'Member', value: 'Member'},
      {name: 'VIP', value: 'VIP'}
    ];
// tslint:disable-next-line: prefer-for-of
    for (let i = 0; i < availableRoles.length; i++) {
      let isMatch = false;
// tslint:disable-next-line: prefer-for-of
      for (let j = 0; j < userRoles.length; j++ ) {
        if (userRoles[j] === availableRoles[i].name) {
          isMatch = true;
          availableRoles[i].checked = true;
          roles.push(availableRoles[i]);
          break;
        }
      }
      if (!isMatch) {
      availableRoles[i].checked = false;
      roles.push(availableRoles[i]);
      }
    }
    return roles;
  }

}
