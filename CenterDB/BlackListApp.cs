using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class BlackListApp
    {
        public long No { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
