using System;
using System.Collections.Generic;

namespace ArchtaxiAPI.Models.Models
{
    public partial class UsersBlacklist
    {
        public int Id { get; set; }
        public string? Ip { get; set; }
        public int? ExpireDays { get; set; }
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
        public bool? DeletedFlag { get; set; }
    }
}
