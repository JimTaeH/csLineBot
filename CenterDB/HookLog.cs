using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class HookLog
    {
        public int No { get; set; }
        public string RequestUri { get; set; }
        public string Jsonbody { get; set; }
        public string ResponseStatus { get; set; }
        public string Response { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? ResponseDate { get; set; }
        public string CustomerId { get; set; }
        public string Jobno { get; set; }
        public string Jobstatus { get; set; }
    }
}
