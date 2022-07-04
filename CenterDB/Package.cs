using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class Package
    {
        public int PackageId { get; set; }
        public int? PackageTypeId { get; set; }
        public string Name { get; set; }
        public decimal? Value { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
