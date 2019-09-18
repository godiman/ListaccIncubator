import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Photo } from 'src/app/modules/Photo';
import { FileUploader } from 'ng2-file-upload';
import { environment } from 'src/environments/environment';
import { AuthService } from 'src/app/_services/auth.service';
import { UserService } from 'src/app/_services/User.service';
import { AlertifyService } from 'src/app/_services/alertify.service';

@Component({
  selector: 'app-photo-edit',
  templateUrl: './photo-edit.component.html',
  styleUrls: ['./photo-edit.component.css']
})

export class PhotoEditComponent implements OnInit {
  uploader: FileUploader;
  hasBaseDropZoneOver = false;
  baseUrl = environment.Url + 'users/';
  currentMain: Photo;
  @Input() Photos: Photo[];
  @Output() getMemberPhotoChange = new EventEmitter<string>();
  constructor(private authService: AuthService, private userService: UserService, private alertify: AlertifyService) { }

  ngOnInit() {
    this.initializeUpload();
    this.currentMain = this.Photos.filter(p => p.isMain)[0];
  }
  fileOverBase(e: any): void {
    this.hasBaseDropZoneOver = e;
  }

  initializeUpload() {
    this.uploader = new FileUploader({
    url: this.baseUrl + this.authService.decodedToken.nameid + '/photos',
    authToken: 'Bearer ' + localStorage.getItem('token'),
    isHTML5: true,
    allowedFileType: ['image'],
    removeAfterUpload: true,
    autoUpload: false,
    maxFileSize: 10 *  1024 * 1024
    });
    this.uploader.onAfterAddingFile = (file) => { file.withCredentials = false; };

    this.uploader.onSuccessItem = (item, response, status, header) => {
      if (Response) {
        const res: Photo = JSON.parse(response);
        const photo = {
          id: res.id,
          url: res.url,
          dateAdded: res.dateAdded,
          description: res.description,
          isMain: res.isMain
        };
        this.Photos.push(photo);
        if (photo.isMain) {
        this.getMemberPhotoChange.emit(photo.url);
        this.authService.currentUser.photoUrl = photo.url;
        localStorage.setItem('user', JSON.stringify(this.authService.currentUser));
        }
      } };
    }

    setMainPhoto(photo: Photo) {
      this.userService.setMainPhoto(this.authService.decodedToken.nameid, photo.id).subscribe(() => {
        this.currentMain.isMain = false;
        photo.isMain = true;
        this.currentMain = photo;
        this.getMemberPhotoChange.emit(photo.url);
        this.authService.currentUser.photoUrl = photo.url;
        localStorage.setItem('user', JSON.stringify(this.authService.currentUser));
      },
      error => {
        this.alertify.error(error);
      });
    }

    deletePhoto(photo: Photo) {
      this.alertify.confirm('Are you sure you want delete this photo', (() => {
      this.userService.deletePhoto(this.authService.decodedToken.nameid, photo.id).subscribe(() => {
        this.Photos.splice(this.Photos.findIndex( p => p.id === photo.id), 1);
        this.alertify.success('Photo has been deleted successfully');
      }, error => {
        this.alertify.error(error);
      });
     }
      ));
    }
}
