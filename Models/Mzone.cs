using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Mzone
    {
        public int No { get; set; }
        public string Zoneid { get; set; }
        public string Description { get; set; }
        public bool? Status { get; set; }
        public DateTime? Createdate { get; set; }
        public DateTime? Updatedate { get; set; }
    }
}
