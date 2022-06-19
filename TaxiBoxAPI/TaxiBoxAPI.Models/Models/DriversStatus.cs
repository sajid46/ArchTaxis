using System;
using System.Collections.Generic;

namespace TaxiBoxAPI.Models.Models
{
    public partial class DriversStatus
    {
        public int Id { get; set; }
        public string? DriverNo { get; set; }
        public string? Status { get; set; }
        public string? Location { get; set; }
    }
}
