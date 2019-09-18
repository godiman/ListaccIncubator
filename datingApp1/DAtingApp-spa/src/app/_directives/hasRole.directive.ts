import { Directive, Input, ViewContainerRef, TemplateRef } from '@angular/core';
import { AuthService } from '../_services/auth.service';

@Directive({
  selector: '[appHasRole]'
})
export class HasRoleDirective {
  @Input() appHasRole: string[];
  isVisible = false;
  constructor(private viewContainerRef: ViewContainerRef,
              private templateRef: TemplateRef<any>,
              private aurthService: AuthService) { }
// tslint:disable-next-line: use-life-cycle-interface
  ngOnInit() {
  const userRoles = this.aurthService.decodedToken.role as Array<string>;
  // if no roles clear the viewContainerRef.
  if (!userRoles) {
    this.viewContainerRef.clear();
  }
  // if user has role need then render the element
  if (this.aurthService.roleMatch(this.appHasRole)) {
    if (!this.isVisible) {
    this.isVisible = true;
    this.viewContainerRef.createEmbeddedView(this.templateRef);
    } else {
      this.isVisible = false;
      this.viewContainerRef.clear();
    }

    }
    }
}

