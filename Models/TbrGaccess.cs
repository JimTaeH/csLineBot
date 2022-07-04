using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class TbrGaccess
    {
        public int GaNo { get; set; }
        public string GaGroupId { get; set; }
        public string GaUserId { get; set; }
        public DateTime? GaCreate { get; set; }
        public bool? GaActive { get; set; }
    }
}
