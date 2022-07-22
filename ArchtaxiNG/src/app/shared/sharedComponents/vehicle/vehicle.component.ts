import { animate, style, transition, trigger } from '@angular/animations';
import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-vehicle',
  templateUrl: './vehicle.component.html',
  styleUrls: ['./vehicle.component.scss'],
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
    trigger('fade2', [
      transition('void => *', [
        animate('5s 5s',
        style({ padding: '0px', width: 0, opacity: 0 })),
        animate(100, style({ padding: '30px 20px', width: '100%', opacity: 1 })),
      ]),
    ]),
  ]
})
export class VehicleComponent implements OnInit {
  @Input() vehicleImage: string="";
  @Input() vehicleDesc: string="";
  @Input() icon="";
  desc!: Array<string>;
  constructor() { }

  ngOnInit(): void {
    this.desc=this.vehicleDesc.split('|');
  }

}
