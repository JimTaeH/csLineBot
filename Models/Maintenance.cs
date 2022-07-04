using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Maintenance
    {
        public int MaId { get; set; }
        public DateTime CreateDate { get; set; }
        public string Hhid { get; set; }
        public int Mid { get; set; }
        public DateTime? Plandate { get; set; }
        public int? Planmile { get; set; }
        public int? Currentmile { get; set; }
        public DateTime? Estdate { get; set; }
        public int? Actionmile { get; set; }
        public DateTime? Actiondate { get; set; }
        public DateTime? Bookdate { get; set; }
        public int? Status { get; set; }
        public DateTime? Lastupdate { get; set; }
        public string Remarks { get; set; }
        public DateTime? Expireddate { get; set; }
    }
}
