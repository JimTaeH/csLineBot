using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Tsale
    {
        public long No { get; set; }
        public string Hhid { get; set; }
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
        public int Battery { get; set; }
        public DateTime Createdate { get; set; }
        public string Actionapp { get; set; }
        public string Compid { get; set; }
        public string Cardimg { get; set; }
        public string Bpcode { get; set; }
        public string StatusBp { get; set; }
        public bool Cflatlng { get; set; }
        public bool Isapprove { get; set; }
        public DateTime Appdate { get; set; }
        public string Appby { get; set; }
    }
}
