using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Msqa
    {
        public int Qaid { get; set; }
        public string Qaname { get; set; }
        public bool? Isactive { get; set; }
    }
}
