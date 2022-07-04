using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Tphoto
    {
        public int No { get; set; }
        public string Hhid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Createdate { get; set; }
        public bool? Isprofile { get; set; }
        public decimal? Lat { get; set; }
        public decimal? Lng { get; set; }
        public string RefCode { get; set; }
    }
}
