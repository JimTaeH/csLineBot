using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class TbmProvince
    {
        public int ProvCountryId { get; set; }
        public int ProvProvinceId { get; set; }
        public string ProvLocalName { get; set; }
        public string ProvEnglishName { get; set; }
    }
}
