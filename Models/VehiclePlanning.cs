using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class VehiclePlanning
    {
        public int Id { get; set; }
        public string DatasetName { get; set; }
        public int? RoutingTypes { get; set; }
        public DateTime? DepartTime { get; set; }
        public int? SearchRange { get; set; }
        public int? Transportmodes { get; set; }
        public int? Tollroads { get; set; }
        public int? Motorways { get; set; }
        public double? TotalCost { get; set; }
        public double? TotalCostSolver { get; set; }
        public double? TotalTransportTime { get; set; }
        public double? TotalServiceTime { get; set; }
        public double? TotalWaitingTime { get; set; }
        public double? TotalDistance { get; set; }
        public double? TotalDuration { get; set; }
        public int? TotalNumberOfVehiclesUsed { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public byte? Status { get; set; }
        public string Refplan { get; set; }
        public string Refdate { get; set; }
        public string Refconfig { get; set; }
    }
}
