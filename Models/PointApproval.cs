using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class PointApproval
    {
        public int No { get; set; }
        public string CustomerId { get; set; }
        public string PointId { get; set; }
        public int ContactId { get; set; }
        public bool? IsActive { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsDefault { get; set; }
    }
}
