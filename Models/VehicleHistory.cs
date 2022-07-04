using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class VehicleHistory
    {
        public VehicleHistory()
        {
            VehicleHistoryDetails = new HashSet<VehicleHistoryDetail>();
        }

        public int No { get; set; }
        public string VehicleHistoryId { get; set; }
        public string Uuid { get; set; }
        public string Hhid { get; set; }
        public string RowType { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string Address { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual ICollection<VehicleHistoryDetail> VehicleHistoryDetails { get; set; }
    }
}
