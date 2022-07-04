using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class VehiclePlanningUnAssign
    {
        public int Id { get; set; }
        public string DatasetName { get; set; }
        public string OrderId { get; set; }
    }
}
