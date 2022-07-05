using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Data
{
    public partial class Mreason
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public bool? Isactive { get; set; }
        public string Rtype { get; set; }
    }
}
