using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class TjobExp
    {
        public string Jobno { get; set; }
        public int Itemid { get; set; }
        public int Itemno { get; set; }
        public double? Amountreq { get; set; }
        public double? Amountapr { get; set; }
        public double? Amountpay { get; set; }
        public string Photo { get; set; }
        public DateTime? Createdate { get; set; }
        public string Createby { get; set; }
    }
}
