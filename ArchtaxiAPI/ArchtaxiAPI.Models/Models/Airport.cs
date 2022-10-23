using System;
using System.Collections.Generic;

namespace ArchtaxiAPI.Models.Models
{
    public partial class Airport
    {
        public int Id { get; set; }
        public string? Airports { get; set; }
        public string? City { get; set; }
        public bool? DeletedFlag { get; set; }
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
    }
}
