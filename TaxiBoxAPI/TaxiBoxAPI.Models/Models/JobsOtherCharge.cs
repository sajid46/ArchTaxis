using System;
using System.Collections.Generic;

namespace TaxiBoxAPI.Models.Models
{
    public partial class JobsOtherCharge
    {
        public int Id { get; set; }
        public double? MeetandGreetCharges { get; set; }
        public double? VehicleTypeCharges { get; set; }
        public double? OtherCharges { get; set; }
        public double? Discount { get; set; }
    }
}
