using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class TbsRoleHeader
    {
        public int RolehId { get; set; }
        public string RolehName { get; set; }
        public bool? RoledActive { get; set; }
        public DateTime? Createdate { get; set; }
        public string Createby { get; set; }
        public DateTime? Updatedate { get; set; }
        public string Updateby { get; set; }
    }
}
