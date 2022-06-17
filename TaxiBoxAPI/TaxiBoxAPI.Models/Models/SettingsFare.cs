using System;
using System.Collections.Generic;

namespace TaxiBoxAPI.Models.Models
{
    public partial class SettingsFare
    {
        public int Id { get; set; }
        public decimal BaseRate { get; set; }
        public decimal BaseRatePerDistance { get; set; }
        public string BaseRateDistanceType { get; set; } = null!;
        public decimal? StartMeterFare { get; set; }
        public string? StartMeterFarePerDistanceType { get; set; }
        public bool DeletedFlag { get; set; }
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
