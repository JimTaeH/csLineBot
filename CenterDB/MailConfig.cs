using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class MailConfig
    {
        public int No { get; set; }
        public string UserId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
