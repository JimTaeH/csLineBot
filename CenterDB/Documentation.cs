using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class Documentation
    {
        public int No { get; set; }
        public string Id { get; set; }
        public string Prefix { get; set; }
        public string Name { get; set; }
        public string StartRun { get; set; }
        public string CurrentRun { get; set; }
        public string Format { get; set; }
        public DateTime? Cdate { get; set; }
    }
}
