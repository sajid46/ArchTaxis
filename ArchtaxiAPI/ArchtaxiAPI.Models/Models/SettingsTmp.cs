using System;
using System.Collections.Generic;

namespace ArchtaxiAPI.Models.Models
{
    public partial class SettingsTmp
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
