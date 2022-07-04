using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Tjobtimeslot
    {
        public int No { get; set; }
        public string Jobno { get; set; }
        public string DropSeq { get; set; }
        public string TimeReceiveFromSlot1 { get; set; }
        public string TimeReceiveToSlot1 { get; set; }
        public string TimeReceiveFromSlot2 { get; set; }
        public string TimeReceiveToSlot2 { get; set; }
        public string TimeDeliveryFromSlot1 { get; set; }
        public string TimeDeliveryToSlot1 { get; set; }
        public string TimeDeliveryFromSlot2 { get; set; }
        public string TimeDeliveryToSlot2 { get; set; }
    }
}
