using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class Mmodule
    {
        public Mmodule()
        {
            Tpckdetails = new HashSet<Tpckdetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Tpckdetail> Tpckdetails { get; set; }
    }
}
