using System;
using System.Collections.Generic;

namespace TaxiBoxAPI.Models.Models
{
    public partial class Setting
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public string? Value { get; set; }
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public byte[]? UpdatedBy { get; set; }
        public bool? DeletedFlag { get; set; }
    }
}
