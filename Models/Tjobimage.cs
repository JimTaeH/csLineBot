using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Tjobimage
    {
        public int No { get; set; }
        public string Jobno { get; set; }
        public string Filename { get; set; }
        public string Hhid { get; set; }
        public DateTime? Createdate { get; set; }
    }
}
