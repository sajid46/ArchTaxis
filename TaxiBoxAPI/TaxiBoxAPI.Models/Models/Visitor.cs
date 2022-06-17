using System;
using System.Collections.Generic;

namespace TaxiBoxAPI.Models.Models
{
    public partial class Visitor
    {
        public int Id { get; set; }
        public string? Visitor1 { get; set; }
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
