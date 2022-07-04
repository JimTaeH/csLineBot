using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Tqueue
    {
        public int No { get; set; }
        public string Hhid { get; set; }
        public string LoadId { get; set; }
        public string Status { get; set; }
        public string Lane { get; set; }
        public string Type { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string AssignBy { get; set; }
        public DateTime? WaitingListDate { get; set; }
        public DateTime? StartLoading { get; set; }
        public DateTime? FinishLoading { get; set; }
        public DateTime? Truckout { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUser { get; set; }
    }
}
