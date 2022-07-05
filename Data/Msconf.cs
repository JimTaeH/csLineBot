using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Data
{
    public partial class Msconf
    {
        public string Appid { get; set; }
        public string Keyname { get; set; }
        public int? Keyorder { get; set; }
        public string Keyvalue { get; set; }
        public string Keylabel { get; set; }
        public string Appidref { get; set; }
        public string Xtype { get; set; }
        public string Xstore { get; set; }
        public DateTime? Updatedt { get; set; }
    }
}
