using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class UsageOnDisk
    {
        public int No { get; set; }
        public string CustomerId { get; set; }
        public decimal? Usage { get; set; }
        public decimal? MaxSize { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}
