using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class TbmGroup
    {
        public string GroupId { get; set; }
        public string GroupName { get; set; }
        public bool? GroupActive { get; set; }
        public int? Radius { get; set; }
        public decimal? Lat { get; set; }
        public decimal? Lng { get; set; }
    }
}
