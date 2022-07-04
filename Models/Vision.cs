using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Vision
    {
        public int Id { get; set; }
        public string Jobno { get; set; }
        public string Tag { get; set; }
        public float? Probability { get; set; }
        public string Name { get; set; }
        public string Hhid { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
