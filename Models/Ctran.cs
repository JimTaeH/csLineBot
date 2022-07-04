using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Ctran
    {
        public long No { get; set; }
        public string Hhid { get; set; }
        public decimal Lati { get; set; }
        public decimal Long { get; set; }
        public double Speed { get; set; }
        public double Direction { get; set; }
        public int Battery { get; set; }
        public string Gstatus { get; set; }
        public DateTime CreateOn { get; set; }
        public string ActionApp { get; set; }
        public string Bpcode { get; set; }
        public double? Distance { get; set; }
        public string Ipaddress { get; set; }
        public string Jobno { get; set; }
        public string Cstatus { get; set; }
        public DateTime? Dcstatus { get; set; }
        public DateTime? ActualTime { get; set; }
        public string Hhstatus { get; set; }
        public int? Accuracy { get; set; }
    }
}
