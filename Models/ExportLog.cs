using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class ExportLog
    {
        public int No { get; set; }
        public string JobNo { get; set; }
        public string JobStatus { get; set; }
        public string ExportType { get; set; }
        public string ReportId { get; set; }
        public DateTime? ExportDate { get; set; }
        public string ExportBy { get; set; }
        public DateTime? ActionDate { get; set; }
    }
}
