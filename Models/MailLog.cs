using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class MailLog
    {
        public int No { get; set; }
        public string JobNo { get; set; }
        public string JobStatus { get; set; }
        public bool? Status { get; set; }
        public string SendFrom { get; set; }
        public string SendTo { get; set; }
        public string MailBody { get; set; }
        public string Remark { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
