using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class MauditType
    {
        public string TypeId { get; set; }
        public string Name { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
