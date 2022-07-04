using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class ExportPdfqueue
    {
        public string Jobno { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
    }
}
