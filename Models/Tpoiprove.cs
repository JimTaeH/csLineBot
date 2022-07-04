using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Tpoiprove
    {
        public int No { get; set; }
        public string Poiid { get; set; }
        public decimal? Lat { get; set; }
        public decimal? Lng { get; set; }
        public bool? Isapprove { get; set; }
        public string Createby { get; set; }
        public DateTime? Createdate { get; set; }
        public string Updateby { get; set; }
        public DateTime? Updatedate { get; set; }
        public string Jobno { get; set; }
    }
}
