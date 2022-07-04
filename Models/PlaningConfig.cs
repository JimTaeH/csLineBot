using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class PlaningConfig
    {
        public int No { get; set; }
        public string Depots { get; set; }
        public string Groupid { get; set; }
        public string Starttime { get; set; }
        public string Endtime { get; set; }
        public string Maxdrop { get; set; }
        public bool? Returnmode { get; set; }
        public int? Deliverymode { get; set; }
        public bool? Groupmode { get; set; }
        public bool? Packmode { get; set; }
        public bool? Vehiclemode { get; set; }
        public bool? Assignmode { get; set; }
        public string DepartureTime { get; set; }
        public int? Modes { get; set; }
        public int? Routingtype { get; set; }
        public int? Tollroads { get; set; }
        public int? Motorways { get; set; }
        public string UpdatebBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
