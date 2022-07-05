using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Data.common
{
    public partial class LineRegister
    {
        public int Id { get; set; }
        public string Dbcode { get; set; }
        public string ContactId { get; set; }
        public string Bpcode { get; set; }
        public string UserId { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public DateTime? RegisterDate { get; set; }
        public DateTime? LastMsgSent { get; set; }
    }
}
