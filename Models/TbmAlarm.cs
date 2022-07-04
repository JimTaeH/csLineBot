using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class TbmAlarm
    {
        public string AlarmId { get; set; }
        public string ModuleId { get; set; }
        public string AlarmName { get; set; }
        public bool? AlarmActive { get; set; }
        public DateTime? AlarmCreate { get; set; }
        public DateTime? AlarmUpdate { get; set; }
    }
}
