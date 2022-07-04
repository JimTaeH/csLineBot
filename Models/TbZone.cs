using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class TbZone
    {
        public int No { get; set; }
        public string Group { get; set; }
        public string Mainzone { get; set; }
        public string Subzone { get; set; }
        public string Zone { get; set; }
        public bool? Status { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? Updatedate { get; set; }
    }
}
