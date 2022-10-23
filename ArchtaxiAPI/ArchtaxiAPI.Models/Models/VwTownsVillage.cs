using System;
using System.Collections.Generic;

namespace ArchtaxiAPI.Models.Models
{
    public partial class VwTownsVillage
    {
        public int Id { get; set; }
        public string? TownsVillages { get; set; }
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
        public bool? DeletedFlag { get; set; }
    }
}
