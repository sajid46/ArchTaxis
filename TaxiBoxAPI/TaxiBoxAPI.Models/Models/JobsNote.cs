using System;
using System.Collections.Generic;

namespace TaxiBoxAPI.Models.Models
{
    public partial class JobsNote
    {
        public int Id { get; set; }
        /// <summary>
        /// COMPLETED, PENDING, CANCELLED
        /// </summary>
        public string? Notes { get; set; }
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string? UpdatedBy { get; set; }
        public bool? DeletedFlag { get; set; }
        public int? JobId { get; set; }

        public virtual Job? Job { get; set; }
    }
}
