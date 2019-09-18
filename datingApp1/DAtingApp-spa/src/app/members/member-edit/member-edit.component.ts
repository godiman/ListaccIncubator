import { Component, OnInit, ViewChild, HostListener } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { User } from 'src/app/modules/user';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { take } from 'rxjs/operators';
import { NgForm } from '@angular/forms';
import { UserService } from 'src/app/_services/User.service';
import { AuthService } from 'src/app/_services/auth.service';
import { CodegenComponentFactoryResolver } from '@angular/core/src/linker/component_factory_resolver';
import { Photo } from 'src/app/modules/Photo';

@Component({
  selector: 'app-member-edit',
  templateUrl: './member-edit.component.html',
  styleUrls: ['./member-edit.component.css']
})
export class MemberEditComponent implements OnInit {
  @ViewChild ('editForm') editForm: NgForm;
  user: User;
  @HostListener('window:beforeunload', ['$event'])
  unloadNotification($event: any) {
    if (this.editForm.dirty) {
    $event.returnValue = true;
    }
  }

  constructor(private route: ActivatedRoute, private alertify: AlertifyService,
              private userService: UserService, private authService: AuthService ) { }

  ngOnInit() {
    this.route.data.subscribe( data => {
      this.user = data.user;
    }  );
  }

  updateUser() {

      this.userService.updateUser(this.authService.decodedToken.nameid, this.user)
      .subscribe(next => {
        this.alertify.success('Profile updated successfully!');
        this.editForm.reset(this.user);
      }, error => {
        this.alertify.error('Problem updating your data');
      }
        );
  }

  updateMainPhoto(photoUrl) {
    this.user.photoUrl = photoUrl;
  }


}
