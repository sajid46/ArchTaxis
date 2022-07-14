import { Directive, ElementRef, Input, OnInit } from '@angular/core';

@Directive({
  selector: '[cdBox]',
})
export class BoxDirective implements OnInit {
  @Input() bgColor!: string;
  width: any;
  height: any;
  top: any;
  left: any;
  top2: any;

  constructor(private eRef: ElementRef) {}

  ngOnInit(): void {
    this.eRef.nativeElement.style.backgroundColor = this.bgColor;
    this.eRef.nativeElement.style.overflow = 'hidden';
    this.top=this.eRef.nativeElement.offsetTop;
    this.top2=this.top + (74 * this.eRef.nativeElement.clientHeight)/100;
    this.left=this.eRef.nativeElement.offsetLeft;
    this.width = this.eRef.nativeElement.clientWidth;
    this.height = this.eRef.nativeElement.clientHeight;
    this.eRef.nativeElement
    .insertAdjacentHTML('beforeend',
    "<div style='overflow: hidden; position: absolute; top: " + this.top + "px; left:" + this.left + "px; background-color: transparent; width:"
    + this.width + "px; height:"
    + this.height + "px;'>" +

    "<div style='margin-top: " + this.top2  + "px; background-color: #ffff002b; width:"
    + this.width + "px; height:"
    + this.height + "px; transform: rotate(140deg);'></div></div>");
  }
}
