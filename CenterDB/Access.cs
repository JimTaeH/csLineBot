using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class Access
    {
        public int No { get; set; }
        public string RoleId { get; set; }
        public string ActionId { get; set; }
        public string MenuId { get; set; }
        public bool? IsAccess { get; set; }

        public virtual MenuAction Action { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual RoleAccess Role { get; set; }
    }
}
