using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Mbpd
    {
        public int No { get; set; }
        public string Bpcode { get; set; }
        public string Bpname { get; set; }
        public string Bptype { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Createby { get; set; }
        public DateTime Createdate { get; set; }
        public bool? Isactive { get; set; }
        public string Loginpwd { get; set; }
        public string Email { get; set; }
        public bool? IsNotifyDaily { get; set; }
        public string Bpref1 { get; set; }
        public string Bpref2 { get; set; }
        public string Bpref3 { get; set; }
        public string Bpref4 { get; set; }
        public bool? Sendmailaccount { get; set; }
        public string Lineimg { get; set; }
        public string Cusimg { get; set; }
    }
}
