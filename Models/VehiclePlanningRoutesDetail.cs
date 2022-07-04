using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class VehiclePlanningRoutesDetail
    {
        public int Id { get; set; }
        public int? SequenceId { get; set; }
        public string OrderId { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public DateTime? DepartTime { get; set; }
        public double? Distance { get; set; }
        public string Activity { get; set; }
        public string VehicleId { get; set; }
        public string DatasetName { get; set; }
    }
}
