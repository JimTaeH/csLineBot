using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class Contact
    {
        public int No { get; set; }
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OfficeTel { get; set; }
        public string MobileNumber { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public bool? IsActive { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
