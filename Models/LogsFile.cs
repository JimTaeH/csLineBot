using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class LogsFile
    {
        public int Id { get; set; }
        public string Refcode { get; set; }
        public string Apiname { get; set; }
        public int? Statuscode { get; set; }
        public string Resmessage { get; set; }
        public string Message { get; set; }
        public string Descriptions { get; set; }
        public DateTime? Createdate { get; set; }
        public string Createby { get; set; }
    }
}
