﻿using System;
using System.Collections.Generic;

namespace TaxiBoxAPI.Models.Models
{
    public partial class Job
    {
        public Job()
        {
            JobsNotes = new HashSet<JobsNote>();
        }

        public int Id { get; set; }
        public string? Pickup { get; set; }
        public string? Destination { get; set; }
        public string? PaxName { get; set; }
        public string? PaxEmail { get; set; }
        public string? PaxMobileNo { get; set; }
        public short? NoOfPax { get; set; }
        public string? Distance { get; set; }
        public string? DurationMinutes { get; set; }
        public double? Fare { get; set; }
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

        public virtual ICollection<JobsNote> JobsNotes { get; set; }
    }
}
