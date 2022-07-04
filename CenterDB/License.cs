using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class License
    {
        public int No { get; set; }
        public string LicenseId { get; set; }
        public string OrderId { get; set; }
        public string DeviceId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public bool? IsActive { get; set; }
        public int? ActivateTotal { get; set; }

        public virtual PreOrder Order { get; set; }
    }
}
