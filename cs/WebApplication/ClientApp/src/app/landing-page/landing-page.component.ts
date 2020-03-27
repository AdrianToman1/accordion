import { Component } from '@angular/core';
import { Router } from "@angular/router";

@Component({
  templateUrl: './landing-page.component.html',
})
export class LandingPageComponent {
  q: string;

  constructor(private router: Router) {}


  doSearch() {
    this.router.navigate(["/search"], { queryParams: { q: this.q } });
  }
}
