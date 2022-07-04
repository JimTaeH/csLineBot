using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class Tpckheader
    {
        public Tpckheader()
        {
            Ocomps = new HashSet<Ocomp>();
            Tpckdetails = new HashSet<Tpckdetail>();
        }

        public string Packcode { get; set; }
        public string Packname { get; set; }
        public decimal? Price { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Ocomp> Ocomps { get; set; }
        public virtual ICollection<Tpckdetail> Tpckdetails { get; set; }
    }
}
