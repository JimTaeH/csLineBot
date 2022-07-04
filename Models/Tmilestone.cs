using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Tmilestone
    {
        public int No { get; set; }
        public string Hhid { get; set; }
        public string JobNo { get; set; }
        public string MilestoneId { get; set; }
        public string JobStatus { get; set; }
        public decimal? Lat { get; set; }
        public decimal? Lng { get; set; }
        public DateTime? CreateDate { get; set; }
        public string RefCode { get; set; }
    }
}
