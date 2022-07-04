using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class TbmQueuestatus
    {
        public string StatusId { get; set; }
        public string StatusName { get; set; }
        public bool? StatusActive { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
