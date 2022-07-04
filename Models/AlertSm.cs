using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class AlertSm
    {
        public string JobNo { get; set; }
        public string SmsalertNumber { get; set; }
        public string SmssenderName { get; set; }
        public bool? IsSmsopen { get; set; }
        public bool? IsSmsreceive { get; set; }
        public bool? IsSmssent { get; set; }
        public bool? IsSmsreject { get; set; }
    }
}
