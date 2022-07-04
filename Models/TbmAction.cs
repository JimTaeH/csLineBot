using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class TbmAction
    {
        public string ActionId { get; set; }
        public string ActionName { get; set; }
        public bool? ActionActive { get; set; }
        public DateTime? ActionCreate { get; set; }
        public DateTime? ActionUpdate { get; set; }
    }
}
