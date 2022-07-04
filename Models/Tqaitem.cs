using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Tqaitem
    {
        public int Qaid { get; set; }
        public string Jobno { get; set; }
        public int Itemno { get; set; }
        public bool? Isok { get; set; }
        public DateTime? Qadate { get; set; }
    }
}
