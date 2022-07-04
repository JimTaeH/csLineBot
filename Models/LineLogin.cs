using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class LineLogin
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
    }
}
