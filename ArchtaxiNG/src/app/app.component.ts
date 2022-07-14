import { Component, HostListener } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'ArchTaxiNG';
  IsSticky = false ;
  str: any;
  IsStickyGetQuote= false;


  @HostListener('window:scroll', ['$event']) // for window scroll events
onScroll(event: any) {
  this.str = event.currentTarget.pageYOffset;
  if(this.str > 24)
  {
    this.IsSticky = true
    this.IsStickyGetQuote = true;
  }
  else
  {
    this.IsSticky = false;
    this.IsStickyGetQuote = false;
  }
}

}
