using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Planning
    {
        public int No { get; set; }
        public string DatasetName { get; set; }
        public string Jobno { get; set; }
        public int? Jobtype { get; set; }
        public string Poiid { get; set; }
        public decimal? Lat { get; set; }
        public decimal? Lng { get; set; }
        public double? Weight { get; set; }
        public double? Volumn { get; set; }
        public double? Height { get; set; }
        public string Refjob { get; set; }
        public DateTime? Createdate { get; set; }
    }
}
