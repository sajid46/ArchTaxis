export interface Ijob {
  id: number;
  Pickup: string;
  Destination: string;
  PaxName: string;
  PaxEmail: string;
  PaxMobileNo: string;
  NoOfPax: string;
  Distance: string;
  DurationMinutes: string;
  Fare: string;
  Discount: string;
  JobStatus: string;
  DateTimePickup: string;
  DriverNo: string;
  Created: string;
  CreatedBy: string;
  Updated: string;
  UpdatedBy: string;
  DeletedFlag: boolean;
  IsPaid: boolean;
  PaymentMethod: string;
  VehicleRequiredID: number;
  DirverComm: string;
  IsMG: boolean;
}
