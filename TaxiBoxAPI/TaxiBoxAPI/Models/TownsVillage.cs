using System;
using System.Collections.Generic;

namespace TaxiBoxAPI.Models
{
    public partial class TownsVillage
    {
        public int Id { get; set; }
        public string? TownsVillages { get; set; }
        public string? County { get; set; }
        public string? Country { get; set; }
        public bool? DeletedFlag { get; set; }
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
    }
}
