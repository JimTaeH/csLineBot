using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class RequestReport
    {
        public int Id { get; set; }
        public string CompId { get; set; }
        public string ReportName { get; set; }
        public DateTime? RequestDatestart { get; set; }
        public DateTime? RequestDateend { get; set; }
        public string RequestQuery { get; set; }
    }
}
