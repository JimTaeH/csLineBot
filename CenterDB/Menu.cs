using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class Menu
    {
        public Menu()
        {
            Accesses = new HashSet<Access>();
        }

        public int No { get; set; }
        public string MenuId { get; set; }
        public string MenuName { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Icon { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Access> Accesses { get; set; }
    }
}
