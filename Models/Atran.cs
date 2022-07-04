using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Atran
    {
        public long No { get; set; }
        public string Hhid { get; set; }
        public decimal Lati { get; set; }
        public decimal Long { get; set; }
        public int Battery { get; set; }
        public string ActionApp { get; set; }
        public DateTime CreateOn { get; set; }
        public string Nimage { get; set; }
        public double Liter { get; set; }
        public double Price { get; set; }
        public double? Distance { get; set; }
        public double? Miles { get; set; }
    }
}
