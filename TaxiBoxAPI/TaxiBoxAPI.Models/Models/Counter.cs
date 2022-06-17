using System;
using System.Collections.Generic;

namespace TaxiBoxAPI.Models.Models
{
    public partial class Counter
    {
        public int Id { get; set; }
        public int? Counter1 { get; set; }
        public int? TotalCounter { get; set; }
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
        public bool? DeletedFlag { get; set; }
    }
}
