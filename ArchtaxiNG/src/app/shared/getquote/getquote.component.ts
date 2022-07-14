import { animate, style, transition, trigger } from '@angular/animations';
import { Component, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Ijob } from '../models/job.model';
import { SharedService } from '../services/shared.service';

@Component({
  selector: 'app-getquote',
  templateUrl: './getquote.component.html',
  styleUrls: ['./getquote.component.scss'],
  animations: [
    trigger('fade1', [
      transition('void => *', [
        style({ opacity: 0 }),
        animate(1100, style({ opacity: 1 })),
      ]),
    ]),
    trigger('fade2', [
      transition('void => *', [
        style({ width: 0, opacity: 0.1 }),
        animate(100, style({ width: '100%', opacity: 0.4 })),
      ]),
    ]),
  ],
})
export class GetquoteComponent implements OnInit {
  Ijob!: Ijob;
  IshideVia: boolean | undefined;
  addViaBtnCaption: string | undefined;
  startDate: Date | undefined;
  quoteForm:
    | FormGroup<{
        pickup: FormControl<null>;
        destination: FormControl<null>;
        addstop: FormControl<null>;
        pickupdate: FormControl<null>;
        pickuptime: FormControl<null>;
      }>
    | undefined;

  formControlItem: FormControl = new FormControl('');
  required: boolean = !1;
  getquoteForm!: FormGroup;
  @ViewChild('timepicker') timepicker: any;

  public enableMaskSupport: boolean = true;
  public maskPlaceholderValue: Object = { hour: 'h', minute: 'm', second: 's' };

  constructor(private sharedService: SharedService) {}

  ngOnInit(): void {
    this.IshideVia = false;
    this.addViaBtnCaption = 'Add Stop';
    this.startDate = new Date(1990, 0, 1);

    this.getquoteForm = new FormGroup({
      pickup: new FormControl(null, [Validators.required]),
      destination: new FormControl(null, [Validators.required]),
      addstop: new FormControl(null, [Validators.required]),
      datetimepickup: new FormControl(null, [Validators.required]),
      datetimepickup2: new FormControl(null, [Validators.required]),
    });


  }

  hideVia() {
    this.IshideVia = !this.IshideVia;
    this.addViaBtnCaption = this.IshideVia == true ? 'Remove Stop' : 'Add Stop';
  }

  onSubmit() {
    var o = this.getquoteForm.value;

    //this.Ijob.id = this.getquoteForm.controls['id'].value;
    this.Ijob.Pickup = this.getquoteForm.controls['pickup'].value;
    this.Ijob.Destination = this.getquoteForm.controls['destination'].value;
    // this.Ijob.PaxName = this.getquoteForm.controls['paxname'].value;
    // this.Ijob.PaxEmail = this.getquoteForm.controls['paxemail'].value;
    // this.Ijob.PaxMobileNo = this.getquoteForm.controls['paxmobileno'].value;
    // this.Ijob.NoOfPax = this.getquoteForm.controls['noofpax'].value;
    // this.Ijob.Distance = this.getquoteForm.controls['distance'].value;
    // this.Ijob.DurationMinutes =
    //   this.getquoteForm.controls['durationminutes'].value;
    // this.Ijob.Fare = this.getquoteForm.controls['fare'].value;
    // this.Ijob.Discount = this.getquoteForm.controls['discount'].value;
    // this.Ijob.JobStatus = this.getquoteForm.controls['jobstatus'].value;
    this.Ijob.DateTimePickup =
      this.getquoteForm.controls['datetimepickup'].value;
    // this.Ijob.DriverNo = this.getquoteForm.controls['driverno'].value;
    // this.Ijob.Created = this.getquoteForm.controls['created'].value;
    // this.Ijob.CreatedBy = this.getquoteForm.controls['createdby'].value;
    // this.Ijob.Updated = this.getquoteForm.controls['updated'].value;
    // this.Ijob.UpdatedBy = this.getquoteForm.controls['updatedby'].value;
    // this.Ijob.DeletedFlag = this.getquoteForm.controls['deletedflag'].value;
    // this.Ijob.IsPaid = this.getquoteForm.controls['ispaid'].value;
    // this.Ijob.PaymentMethod = this.getquoteForm.controls['paymentmethod'].value;
    // this.Ijob.VehicleRequiredID =
    //   this.getquoteForm.controls['vehiclerequiredid'].value;
    // this.Ijob.DirverComm = this.getquoteForm.controls['dirvercomm'].value;
    // this.Ijob.IsMG = this.getquoteForm.controls['ismg'].value;
  }
}

export const MY_FORMATS = {
  parse: {
    dateInput: 'LL',
  },
  display: {
    dateInput: 'YYYY-MM-DD',
    monthYearLabel: 'YYYY',
    dateA11yLabel: 'LL',
    monthYearA11yLabel: 'YYYY',
  },
};
