using System;
using System.Collections.Generic;

namespace ArchtaxiAPI.Models.Models
{
    public partial class DriversStatus
    {
        public int Id { get; set; }
        public string? DriverNo { get; set; }
        public string? Status { get; set; }
        public string? Location { get; set; }
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public byte[]? UpdatedBy { get; set; }
        public bool? DeletedFlag { get; set; }
    }
}
