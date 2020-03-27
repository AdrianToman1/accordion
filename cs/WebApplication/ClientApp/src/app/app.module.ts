import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { ResultsComponent } from './results.component';
import { LandingPageComponent } from './landing-page/landing-page.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { SearchResultsComponent } from './search-results/search-results.component';
import { HtmlContentComponent } from './html-content/html-content.component';

@NgModule({
  declarations: [
    AppComponent,
    ResultsComponent,
    LandingPageComponent,
    NavMenuComponent,
    SearchResultsComponent,
    HtmlContentComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: LandingPageComponent, pathMatch: 'full' },
      {
        path: "search",
        component: ResultsComponent,
        children: [
          { path: '', component: SearchResultsComponent }
        ]
      },
      {
        path: "html-content",
        component: ResultsComponent,
        children: [
          { path: '', component: HtmlContentComponent }
        ]
      }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
