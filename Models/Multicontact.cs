using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Multicontact
    {
        public int Id { get; set; }
        public string Jobno { get; set; }
        public string ContactR { get; set; }
        public DateTime? Receiveupdate { get; set; }
        public string ContactD { get; set; }
        public DateTime? Deliveryupdate { get; set; }
        public string Updateby { get; set; }
    }
}
