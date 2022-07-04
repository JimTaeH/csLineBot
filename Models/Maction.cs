using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Maction
    {
        public int ActionId { get; set; }
        public string ActionName { get; set; }
        public string TypeId { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
