using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Cmileage
    {
        public long No { get; set; }
        public string Hhid { get; set; }
        public decimal Lat { get; set; }
        public decimal Long { get; set; }
        public double Cmileage1 { get; set; }
        public double Mmileage { get; set; }
        public DateTime CreateOn { get; set; }
    }
}
