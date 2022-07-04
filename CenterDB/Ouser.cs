using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class Ouser
    {
        public int No { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string Status { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
