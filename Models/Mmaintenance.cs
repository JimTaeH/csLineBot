using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Mmaintenance
    {
        public int No { get; set; }
        public string Description { get; set; }
        public string VehicleType { get; set; }
        public int Type { get; set; }
        public int? Mileages { get; set; }
        public int? Monthduration { get; set; }
        public int? SubType { get; set; }
    }
}
