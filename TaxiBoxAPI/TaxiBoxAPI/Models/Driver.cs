using System;
using System.Collections.Generic;

namespace TaxiBoxAPI.Models
{
    public partial class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? DriverNo { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Town { get; set; }
        public string? PostCode { get; set; }
        public string? TelNo { get; set; }
        public string? MobileNo { get; set; }
        public string? Email { get; set; }
        public byte? VehicleId { get; set; }
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public byte[]? UpdatedBy { get; set; }
        public bool? DeletedFlag { get; set; }
    }
}
