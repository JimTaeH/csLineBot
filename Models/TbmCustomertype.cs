using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class TbmCustomertype
    {
        public string TypeId { get; set; }
        public string TypeName { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
