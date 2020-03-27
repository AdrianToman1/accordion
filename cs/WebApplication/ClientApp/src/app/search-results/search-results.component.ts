import { Component } from '@angular/core';

@Component({
  templateUrl: './search-results.component.html'
})
export class SearchResultsComponent {
  searchResults: SearchResult[];

  constructor() {
    this.searchResults = [
      {
        title: "Demo",
        url: "/html-content",
        description: "A demo example"
      }
    ];
  }
}

class SearchResult {
  title: string;
  url: string;
  description: string;
}
