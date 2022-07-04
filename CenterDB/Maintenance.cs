using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class Maintenance
    {
        public string MaintenanceId { get; set; }
        public string CustomerId { get; set; }
        public int? PeriodBackup { get; set; }
        public int? PeriodExpire { get; set; }
        public DateTime? BackupDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
