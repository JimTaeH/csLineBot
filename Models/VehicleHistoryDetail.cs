using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class VehicleHistoryDetail
    {
        public int No { get; set; }
        public string VehicleHistoryId { get; set; }
        public string RowType { get; set; }
        public string KeyType { get; set; }
        public decimal? Value { get; set; }

        public virtual VehicleHistory VehicleHistory { get; set; }
    }
}
