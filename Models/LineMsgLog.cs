using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class LineMsgLog
    {
        public int Id { get; set; }
        public DateTime? SentTime { get; set; }
        public string ReplyToken { get; set; }
        public string ToUser { get; set; }
        public string PostedData { get; set; }
    }
}
