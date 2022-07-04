using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Mmilestone
    {
        public string MilestoneId { get; set; }
        public string Name { get; set; }
        public string JobType { get; set; }
        public bool? IsActive { get; set; }
    }
}
