using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Tjitem
    {
        public string Jobno { get; set; }
        public int Itemno { get; set; }
        public string Itemname { get; set; }
        public double? Width { get; set; }
        public double? Lenght { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }
        public double Qty { get; set; }
        public DateTime Cdate { get; set; }
        public string Containerno { get; set; }
        public bool? Isqa { get; set; }
        public string Ref { get; set; }
        public bool? Rusty { get; set; }
        public bool? Wet { get; set; }
        public bool? Crack { get; set; }
        public bool? Dent { get; set; }
        public bool? Cover { get; set; }
        public bool? Hoop { get; set; }
        public bool? Rmout { get; set; }
        public bool? Rmin { get; set; }
        public string Sealno { get; set; }
        public double? Rqty { get; set; }
        public double? Dqty { get; set; }
        public string Rimg { get; set; }
        public string Dimg { get; set; }
        public string Rreason { get; set; }
        public string Dreason { get; set; }
        public string Rstatus { get; set; }
        public string Dstatus { get; set; }
        public string Unit { get; set; }
        public string ItemType { get; set; }
    }
}
