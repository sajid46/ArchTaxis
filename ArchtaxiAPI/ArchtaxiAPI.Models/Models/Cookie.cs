using System;
using System.Collections.Generic;

namespace ArchtaxiAPI.Models.Models
{
    public partial class Cookie
    {
        public int Id { get; set; }
        public int? CookrieId { get; set; }
        public DateTime? Expires { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
