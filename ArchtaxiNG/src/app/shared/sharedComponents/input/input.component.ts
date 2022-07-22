import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-input',
  templateUrl: './input.component.html',
  styleUrls: ['./input.component.scss']
})
export class InputComponent implements OnInit {
  @Input() sm_inputLabelDesc=""
  @Input() sm_divDesc="";
  @Input() sm_inputType="text";
  @Input() sm_inputId="";
  @Input() sm_inputTitle="";
  @Input() sm_inputPlaceholder="";
  @Input() sm_inputformControlName="";
  @Input() sm_formGroup="";
  @Input() sm_icon = "";

  constructor() { }

  ngOnInit(): void {
  }

}
