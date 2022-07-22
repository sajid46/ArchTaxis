import { animate, query, stagger, style, transition, trigger } from '@angular/animations';
import { Component, HostListener, OnInit } from '@angular/core';
import { interval, map, tap, Observable } from 'rxjs';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
  animations:[
    trigger('fade',[
      transition('void => *',[
        animate('0s 1s',
        style({opacity: 0, transform: 'translateX(0px)'})),
          animate(2900, style({opacity: 1, transform: 'translateX(-100px)'})),
      ]),
    ]),
    trigger('carfade',[
      transition('* => *',[
        animate('0s 0s',
        style({opacity: 0})),
        animate(0, style({opacity: 0, transform: 'translateY(0px)'})),
        animate('0s .5s',
        style({})),
        animate(2000, style({opacity: 1, transform: 'translateY(0px)'})),
      ]),
    ]),
    trigger('pageAnimations', [
      transition(':enter', [
        query('.hero', [
          style({opacity: 0, transform: 'translateY(-100px)'}),
          stagger(30, [
            animate('500ms cubic-bezier(0.35, 0, 0.25, 1)',
            style({ opacity: 1, transform: 'none' }))
          ])
        ])
      ])
    ]),
    trigger('fade2', [
      transition('void => *', [
        animate('5s 5s',
        style({ padding: '0px', width: 0, opacity: 0 })),
        animate(100, style({ padding: '30px 20px', width: '100%', opacity: 1 })),
      ]),
    ]),
  ]
})
export class HomeComponent implements OnInit {
  IsStickyGetQuote = false;
  bgcolor!: string;
  setTimer$: Observable<any> | undefined;

  salooncarImage= "../../../assets/vehicles/SaloonCar-removebg-preview.png";
  salooncarDesc= "Saloon Car|4 Seaters (Low Car)|2 Large Suitcase|1 Large & 2 Small Suitcase";

  executivecarImage= "../../../assets/vehicles/SaloonCar-removebg-preview.png";
  executivecarDesc= "Executive Car|4 Seaters (Low Car)|2 Large Suitcase|1 Large & 2 Small Suitcase";

  mpvcarImage= "../../../assets/vehicles/MPVCar1-removebg-preview.png";
  mpvcarDesc= "MPV Vehicle|5-6 Seaters|4-5 Large Suitcase|4 Large & 2 Small Suitcase";

  wheelchaircarImage= "../../../assets/vehicles/WC1-removebg-preview.png";
  wheelchaircarDesc= "Wheelchair Accessible|4 Seaters|6 Large Suitcase|4 Large & 2 Small Suitcase";

  _8seatercarImage= "../../../assets/vehicles/8Seater-removebg-preview.png";
  _8seatercarDesc= "Larger Vehicle|8 Seaters|6 Large Suitcase|4 Large & 2 Small Suitcase";

  constructor() { }

  ngOnInit(): void {
    this.bgcolor='red';
    this.setTimer$= interval(100)

    this.setTimer$.pipe(
      tap(k => console.log(k))
    );


  }

  @HostListener('window:scroll', ['$event']) // for window scroll events
  onScroll(event: any) {
    var str = event.currentTarget.pageYOffset;
    if(str > 10)
    {
      this.IsStickyGetQuote = true;
    }
    else
    {
      this.IsStickyGetQuote = false;
    }
  }
}
