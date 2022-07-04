using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class DriverSkillMaster
    {
        public string Hhids { get; set; }
        public string SkillMaster { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int DriverMasterCode { get; set; }
    }
}
