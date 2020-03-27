import { Component, ViewChild, ElementRef, AfterViewInit } from '@angular/core';

@Component({
  templateUrl: './html-content.component.html'
})
export class HtmlContentComponent implements AfterViewInit {
  @ViewChild('content', null) contentRef: ElementRef;

  async ngAfterViewInit() {
    this.contentRef.nativeElement.innerHTML = await this.fetchHtmlAsText("/content?id=test");
  }

  async fetchHtmlAsText(url) {
    return await (await fetch(url)).text();
  }
}
