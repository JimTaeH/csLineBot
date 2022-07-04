using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class RoleAccess
    {
        public RoleAccess()
        {
            Accesses = new HashSet<Access>();
            Accounts = new HashSet<Account>();
        }

        public int No { get; set; }
        public string RoleId { get; set; }
        public string Rolename { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Access> Accesses { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
