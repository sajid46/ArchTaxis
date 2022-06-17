using System;
using System.Collections.Generic;

namespace TaxiBoxAPI.Models.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? UserId { get; set; }
        public string? Password { get; set; }
        public bool? IsSuperAdmin { get; set; }
        public bool? IsAdmin { get; set; }
        public bool? IsUser { get; set; }
        public bool? DeletedFlag { get; set; }
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
    }
}
