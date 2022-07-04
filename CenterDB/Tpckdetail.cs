using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class Tpckdetail
    {
        public int No { get; set; }
        public string Packcode { get; set; }
        public int Moduleid { get; set; }

        public virtual Mmodule Module { get; set; }
        public virtual Tpckheader PackcodeNavigation { get; set; }
    }
}
