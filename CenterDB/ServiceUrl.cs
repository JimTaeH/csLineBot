using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class ServiceUrl
    {
        public string CompanyCode { get; set; }
        public string Base { get; set; }
        public string Soap { get; set; }
        public string Mobile { get; set; }
        public string Interface { get; set; }
        public string Node { get; set; }
        public string NodeApi { get; set; }
        public string Socket { get; set; }
        public bool? IsActive { get; set; }
    }
}
