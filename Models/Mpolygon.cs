using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Mpolygon
    {
        public int PolygonId { get; set; }
        public string PolygonCode { get; set; }
        public string PolygonName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
