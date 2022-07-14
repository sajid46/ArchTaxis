import { Component, OnInit } from '@angular/core';
import { DriversService } from '../shared/drivers.service';
import { Observable } from 'rxjs';
import { tap } from 'rxjs/operators';

@Component({
  selector: 'app-drivers',
  templateUrl: './drivers.component.html',
  styleUrls: ['./drivers.component.scss']
})
export class DriversComponent implements OnInit {
  drivers$: Observable<any[]> | undefined;

  constructor(private drivers: DriversService) { }

  ngOnInit(): void {
    this.drivers$ = this.drivers.getDrivers();

    this.drivers$.subscribe(
      (p:any) => console.log(p)
    );
  }


}
