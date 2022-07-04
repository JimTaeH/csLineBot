using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class TbmModule
    {
        public string ModuleId { get; set; }
        public string ModuleName { get; set; }
        public bool? ModuleActive { get; set; }
        public string ModuleDescription { get; set; }
    }
}
