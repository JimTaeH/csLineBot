using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class RePassLog
    {
        public int No { get; set; }
        public string Userid { get; set; }
        public string Token { get; set; }
        public string Receivedmail { get; set; }
        public DateTime? Expiredmail { get; set; }
        public DateTime? Createdate { get; set; }
        public int? Mailcount { get; set; }
        public bool? Restatus { get; set; }
    }
}
