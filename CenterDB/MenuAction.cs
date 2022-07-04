using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class MenuAction
    {
        public MenuAction()
        {
            Accesses = new HashSet<Access>();
        }

        public int No { get; set; }
        public string ActionId { get; set; }
        public string ActionName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Access> Accesses { get; set; }
    }
}
