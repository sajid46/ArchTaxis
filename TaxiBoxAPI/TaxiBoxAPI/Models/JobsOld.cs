using System;
using System.Collections.Generic;

namespace TaxiBoxAPI.Models
{
    public partial class JobsOld
    {
        public int Id { get; set; }
        public string? Pickup { get; set; }
        public string? Destination { get; set; }
        public string? PassengerName { get; set; }
        public int? NoOfPassengers { get; set; }
        public double? Fare { get; set; }
        /// <summary>
        /// IF A JOB HAS BEEN DISCOUNTED.. THEN DRIVER COMMISSIONED SHOULD BE DROPPED..
        /// </summary>
        public decimal? Discount { get; set; }
        /// <summary>
        /// COMPLETED, PENDING, CANCELLED
        /// </summary>
        public string? JobStatus { get; set; }
        public string? DateTimePickup { get; set; }
        public string? Notes { get; set; }
        public string? DriverNo { get; set; }
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string? UpdatedBy { get; set; }
        public bool? DeletedFlag { get; set; }
        public bool? PaidTf { get; set; }
        public string? PaymentMethod { get; set; }
        public int? VehicleRequiredId { get; set; }
        public double? DirverComm { get; set; }
        public bool? MeetAndGreet { get; set; }
        public double? Distance { get; set; }
        public int? DurationMinutes { get; set; }
    }
}
