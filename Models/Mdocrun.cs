using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Mdocrun
    {
        public int Docno { get; set; }
        public int Docid { get; set; }
        public string Type { get; set; }
        public string Docname { get; set; }
        public string Prefix { get; set; }
        public string Startrun { get; set; }
        public string Currentrun { get; set; }
        public string Customtext { get; set; }
        public bool? Isdefault { get; set; }
        public bool? Ishidden { get; set; }
        public bool? Isactive { get; set; }
        public DateTime? Lastcreate { get; set; }
        public string Docformat { get; set; }
        public int? Unloadtime { get; set; }
        public int? Loadtime { get; set; }
        public int? Subtype { get; set; }
        public int? Maxloadtime { get; set; }
        public int? Maxunloadtime { get; set; }
    }
}
