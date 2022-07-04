using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class Ocomp
    {
        public long No { get; set; }
        public string CompId { get; set; }
        public string CompName { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
        public int AmountUser { get; set; }
        public int AmountHh { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string CreateBy { get; set; }
        public string Packcode { get; set; }
        public DateTime? Bakdate { get; set; }
        public int? Bakterms { get; set; }
        public string Dbtype { get; set; }

        public virtual Tpckheader PackcodeNavigation { get; set; }
    }
}
