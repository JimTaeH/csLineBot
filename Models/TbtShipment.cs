using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class TbtShipment
    {
        public string LoadId { get; set; }
        public string LoadIdref { get; set; }
        public string Hhid { get; set; }
        public string GroupId { get; set; }
        public string Type { get; set; }
        public string Carrier { get; set; }
        public string Status { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public string Ref5 { get; set; }
        public string Ref6 { get; set; }
        public string Ref7 { get; set; }
        public string Ref8 { get; set; }
        public string Ref9 { get; set; }
        public string Ref10 { get; set; }
        public string Ref11 { get; set; }
        public string Ref12 { get; set; }
        public string Attachfile { get; set; }
        public string Attachname { get; set; }
        public string TruckType { get; set; }
        public double? Qty { get; set; }
        public DateTime? Eta { get; set; }
        public double? Weight { get; set; }
        public double? Volume { get; set; }
        public double? PdeliverDistance { get; set; }
        public double? PtotalDistance { get; set; }
        public double? PdeliverTime { get; set; }
        public double? PtotalTime { get; set; }
        public double? AdeliverDistance { get; set; }
        public double? AtotalDistance { get; set; }
        public double? AdeliverTime { get; set; }
        public double? AtotalTime { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public string Flag { get; set; }
        public DateTime? StatusDate { get; set; }
        public DateTime? InterfaceDate { get; set; }
    }
}
