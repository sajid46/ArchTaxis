using System;
using System.Collections.Generic;

namespace TaxiBoxAPI.Models
{
    public partial class TaxiCompany
    {
        public int Id { get; set; }
        public string? CompanyName { get; set; }
        public string? Address { get; set; }
        public string? Town { get; set; }
        public string? County { get; set; }
        public string? Country { get; set; }
        public string? PostCode { get; set; }
        public string? Telephone { get; set; }
        public string? Email { get; set; }
        public string? Notes { get; set; }
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public byte[]? UpdatedBy { get; set; }
        public bool? DeletedFlag { get; set; }
    }
}
