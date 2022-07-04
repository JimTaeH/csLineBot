using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class Account
    {
        public Account()
        {
            PreOrders = new HashSet<PreOrder>();
        }

        public int No { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Prefix { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Telephone { get; set; }
        public string OfficeId { get; set; }
        public string RoleId { get; set; }
        public bool? IsActive { get; set; }

        public virtual Office Office { get; set; }
        public virtual RoleAccess Role { get; set; }
        public virtual ICollection<PreOrder> PreOrders { get; set; }
    }
}
