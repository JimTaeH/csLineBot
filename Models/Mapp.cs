using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Mapp
    {
        public string Appid { get; set; }
        public string Appname { get; set; }
        public bool Isactive { get; set; }
        public string Appicon { get; set; }
        public DateTime? Updatedt { get; set; }
    }
}
