using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class Office
    {
        public Office()
        {
            Accounts = new HashSet<Account>();
        }

        public int No { get; set; }
        public string OfficeId { get; set; }
        public string OfficeName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
