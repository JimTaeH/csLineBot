using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Tmad
    {
        public int No { get; set; }
        public string Id { get; set; }
        public string Hhid { get; set; }
        public DateTime? Checkin { get; set; }
        public DateTime? Checkout { get; set; }
        public string Garage { get; set; }
        public double? Mile { get; set; }
        public double? Expense { get; set; }
        public string Service { get; set; }
    }
}
