using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Multilanguage
    {
        public int No { get; set; }
        public string FormId { get; set; }
        public string ValueId { get; set; }
        public string DisplayId { get; set; }
        public string DisplayEn { get; set; }
        public string DisplayTh { get; set; }
        public string DisplayVn { get; set; }
        public string DisplayMy { get; set; }
    }
}
