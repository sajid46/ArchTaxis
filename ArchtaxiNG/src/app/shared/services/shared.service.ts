import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {

  private pickup = new BehaviorSubject<string>('');
pickupCast = this.pickup.asObservable();

  constructor() { }

  editPickupForm(pickup: string){
    this.pickup.next(pickup);
  }
}
