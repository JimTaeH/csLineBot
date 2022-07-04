using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class TbsAction
    {
        public string AccCopid { get; set; }
        public string AccModid { get; set; }
        public string AccActionid { get; set; }
        public int AccNo { get; set; }
        public string AccImages { get; set; }
        public bool? AccIsactive { get; set; }
        public DateTime? AccCdate { get; set; }
        public DateTime? AccUdate { get; set; }
    }
}
