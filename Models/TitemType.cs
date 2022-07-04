using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class TitemType
    {
        public string ItemTypeId { get; set; }
        public string ItemTypeName { get; set; }
        public bool? ItemTypeStatus { get; set; }
        public DateTime? ItemTypeCdate { get; set; }
        public DateTime? ItemTypeUdate { get; set; }
    }
}
