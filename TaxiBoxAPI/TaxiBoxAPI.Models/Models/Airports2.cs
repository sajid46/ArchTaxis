using System;
using System.Collections.Generic;

namespace TaxiBoxAPI.Models.Models
{
    public partial class Airports2
    {
        public int? Id { get; set; }
        public string? Airport { get; set; }
        public string? AirportCode { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? CountryAbbrev { get; set; }
        public string? WorldAreaCode { get; set; }
        public bool? DeletedFlag { get; set; }
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
