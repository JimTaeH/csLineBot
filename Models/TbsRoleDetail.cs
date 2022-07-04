using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class TbsRoleDetail
    {
        public int RoledRolehId { get; set; }
        public string RoledMenuId { get; set; }
        public string RoledType { get; set; }
        public DateTime? RoledCdate { get; set; }
    }
}
