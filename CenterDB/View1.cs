using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class View1
    {
        public string LicenseId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string CustomerName { get; set; }
        public string DeviceId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int Amount { get; set; }
        public string PeriodName { get; set; }
        public string CustomerId { get; set; }
        public string CreateBy { get; set; }
    }
}
