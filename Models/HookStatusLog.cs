using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class HookStatusLog
    {
        public string Jobno { get; set; }
        public bool? StatusB { get; set; }
        public bool? StatusR { get; set; }
        public bool? StatusS { get; set; }
        public bool? StatusC { get; set; }
        public bool? StatusA { get; set; }
        public bool? StatusE { get; set; }
        public bool? StatusP { get; set; }
        public bool? NotFound { get; set; }
    }
}
