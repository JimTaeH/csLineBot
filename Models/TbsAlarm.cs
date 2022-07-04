using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class TbsAlarm
    {
        public string ArcUserid { get; set; }
        public string ArcModuleid { get; set; }
        public string ArcAlarmid { get; set; }
        public string ArcOperator { get; set; }
        public int? ArcValue { get; set; }
        public bool? ArcIsactive { get; set; }
        public DateTime? ArcCdate { get; set; }
        public DateTime? ArcUdate { get; set; }
    }
}
