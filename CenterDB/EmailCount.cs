using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class EmailCount
    {
        public int No { get; set; }
        public string Email { get; set; }
        public int EmailType { get; set; }
        public int Counter { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? Status { get; set; }
    }
}
