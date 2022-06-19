using System;
using System.Collections.Generic;

namespace TaxiBoxAPI.Models
{
    public partial class FixedPricedJourny
    {
        public int Id { get; set; }
        public string? Pickup { get; set; }
        public string? Destination { get; set; }
        public decimal? DayPrice { get; set; }
        public decimal? NightPrice { get; set; }
        public bool? DeletedFlag { get; set; }
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
