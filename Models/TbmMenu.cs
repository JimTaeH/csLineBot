using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class TbmMenu
    {
        public string MenuId { get; set; }
        public string MenuModuleid { get; set; }
        public string MenuName { get; set; }
        public bool? MenuActive { get; set; }
        public string MenuDescription { get; set; }
        public string MenuLayout { get; set; }
        public string MenuType { get; set; }
        public string MenuCssname { get; set; }
    }
}
