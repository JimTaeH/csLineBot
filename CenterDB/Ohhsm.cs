using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class Ohhsm
    {
        public long No { get; set; }
        public string Hhid { get; set; }
        public string CompId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public bool Status { get; set; }
        public string CreateBy { get; set; }
    }
}
