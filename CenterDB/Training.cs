using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class Training
    {
        public int No { get; set; }
        public string TraningId { get; set; }
        public string Title { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsAllDay { get; set; }
        public bool? IsActive { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string ClassName { get; set; }
        public string Note { get; set; }
    }
}
