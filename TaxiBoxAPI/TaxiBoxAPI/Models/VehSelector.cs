﻿using System;
using System.Collections.Generic;

namespace TaxiBoxAPI.Models
{
    public partial class VehSelector
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public int? NoOfPeople { get; set; }
        public byte? LargeSuitecase { get; set; }
        public byte? MediumSuitecase { get; set; }
        public bool? WheelChairAccessible { get; set; }
        public string? PercentIncreament { get; set; }
        public byte[]? VehImage { get; set; }
        public DateTime? Created { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public byte[]? UpdatedBy { get; set; }
        public bool? DeletedFlag { get; set; }
    }
}
