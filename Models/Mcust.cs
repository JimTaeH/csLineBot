using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Mcust
    {
        public string Bpcode { get; set; }
        public string Bpname { get; set; }
        public string Address { get; set; }
        public decimal Lati { get; set; }
        public decimal Long { get; set; }
    }
}
