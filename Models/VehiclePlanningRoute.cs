using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class VehiclePlanningRoute
    {
        public int Id { get; set; }
        public string DatasetName { get; set; }
        public string VehicleId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public double? TotalDistance { get; set; }
        public double? TotalDuration { get; set; }
        public double? TotalTransporttime { get; set; }
        public double? TotalServicetime { get; set; }
        public double? TotalWaitingtime { get; set; }
        public double? MaxcapacityWeight { get; set; }
        public double? MaxcapacityVolume { get; set; }
        public int? Recalculate { get; set; }
        public bool? Modify { get; set; }
        public string Loadid { get; set; }
        public int? Route { get; set; }
        public int? Sendapi { get; set; }
        public bool? Isassign { get; set; }
        public string AssignBy { get; set; }
        public DateTime? AssignDate { get; set; }
    }
}
