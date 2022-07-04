using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class DeviceType
    {
        public int DriverTypeId { get; set; }
        public string Name { get; set; }
        public int? Lv { get; set; }
        public string Class { get; set; }
    }
}
