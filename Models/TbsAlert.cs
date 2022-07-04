using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class TbsAlert
    {
        public int No { get; set; }
        public string Hhid { get; set; }
        public string Userid { get; set; }
        public decimal? Lat { get; set; }
        public decimal? Lng { get; set; }
        public string Alarmid { get; set; }
        public string Actionid { get; set; }
        public string Detail { get; set; }
        public DateTime? Alarmdate { get; set; }
    }
}
