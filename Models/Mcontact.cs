using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Mcontact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public bool Isdefault { get; set; }
        public string Createby { get; set; }
        public DateTime Createdate { get; set; }
        public string Bpcode { get; set; }
        public string Fullname { get; set; }
        public string Password { get; set; }
        public DateTime? ExprieDate { get; set; }
        public bool? IsSendSms { get; set; }
        public bool? IsNotifyReceived { get; set; }
        public bool? IsNotifyCompleted { get; set; }
        public bool? IsNotifyRejected { get; set; }
        public bool? IsNotifyArrival { get; set; }
        public bool? IsNotifyPartial { get; set; }
        public bool? IsNotifyOpen { get; set; }
    }
}
