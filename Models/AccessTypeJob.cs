using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class AccessTypeJob
    {
        public int No { get; set; }
        public string UserId { get; set; }
        public int JobTypeId { get; set; }
        public bool IsActive { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdaeBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
