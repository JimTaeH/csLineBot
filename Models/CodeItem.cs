using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class CodeItem
    {
        public string CodeItem1 { get; set; }
        public string Description { get; set; }
        public bool? Actived { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string ItemTypeCode { get; set; }
        public double? Width { get; set; }
        public double? Length { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }
    }
}
