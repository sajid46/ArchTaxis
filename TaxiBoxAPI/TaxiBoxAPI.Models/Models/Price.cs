using System;
using System.Collections.Generic;

namespace TaxiBoxAPI.Models.Models
{
    public partial class Price
    {
        public int Id { get; set; }
        public string? Pickup { get; set; }
        public string? Destination { get; set; }
        public decimal? DayPrice { get; set; }
        public decimal? NightPrice { get; set; }
        public bool? DeletedFlag { get; set; }
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
    }
}
