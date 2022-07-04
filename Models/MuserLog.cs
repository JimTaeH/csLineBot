using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class MuserLog
    {
        public int No { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Createby { get; set; }
    }
}
