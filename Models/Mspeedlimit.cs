using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Mspeedlimit
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public int Speedlimit { get; set; }
        public bool? Isactive { get; set; }
        public int? Alarmfeq { get; set; }
        public int? Avgday { get; set; }
        public double? Volume { get; set; }
        public double? Weights { get; set; }
        public double? Height { get; set; }
        public double? Fuelcost { get; set; }
        public double? Fixedcost { get; set; }
        public double? Timecost { get; set; }
    }
}
