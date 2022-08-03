using System;
using System.Collections.Generic;

namespace ArchtaxiAPI.Models.Models
{
    public partial class VwJobswithNote
    {
        public int Id { get; set; }
        public string? Pickup { get; set; }
        public string? Destination { get; set; }
        public string? PaxName { get; set; }
        public string? PaxEmail { get; set; }
        public string? PaxMobileNo { get; set; }
        public int? NoOfPassengers { get; set; }
        public string? Distance { get; set; }
        public string? DurationMinutes { get; set; }
        public double? Fare { get; set; }
        public double? MeetandGreetCharges { get; set; }
        public double? VehicleTypeCharges { get; set; }
        public double? OtherCharges { get; set; }
        public double? Discount { get; set; }
        public string? JobStatus { get; set; }
        public string? DateTimePickup { get; set; }
        public string? DriverNo { get; set; }
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string? UpdatedBy { get; set; }
        public bool? DeletedFlag { get; set; }
        public bool? IsPaid { get; set; }
        public string? PaymentMethod { get; set; }
        public int? VehicleRequiredId { get; set; }
        public double? DirverComm { get; set; }
        public bool? IsMg { get; set; }
        public string? Notes { get; set; }
    }
}
