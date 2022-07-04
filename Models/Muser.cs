using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Muser
    {
        public int No { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string UFname { get; set; }
        public string ULname { get; set; }
        public string UPhone { get; set; }
        public int? URoleId { get; set; }
        public string UPositionId { get; set; }
        public bool? UActive { get; set; }
        public DateTime? UCreate { get; set; }
        public DateTime? UUpdate { get; set; }
        public string UBpcode { get; set; }
        public string UType { get; set; }
        public string Email { get; set; }
        public bool? Sendmailaccount { get; set; }
        public string Lineimg { get; set; }
        public string Userimg { get; set; }
    }
}
