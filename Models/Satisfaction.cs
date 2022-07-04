using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Satisfaction
    {
        public string JobNo { get; set; }
        public string JobStatus { get; set; }
        public int Rate { get; set; }
        public string ReasonCode { get; set; }
        public string Remark { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
