using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class SkillMaster
    {
        public int Id { get; set; }
        public string SkillCode { get; set; }
        public string SkillDescription { get; set; }
        public bool? Defaults { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
