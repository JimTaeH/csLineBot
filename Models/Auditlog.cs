using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Auditlog
    {
        public int No { get; set; }
        public string TypeId { get; set; }
        public int ActionId { get; set; }
        public string UserName { get; set; }
        public string Status { get; set; }
        public string Detail { get; set; }
        public DateTime? CreateDate { get; set; }
        public int DeleteFlag { get; set; }
    }
}
