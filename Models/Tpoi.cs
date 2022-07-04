using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Tpoi
    {
        public string Poiid { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Createby { get; set; }
        public string Subtype { get; set; }
        public decimal? Lat { get; set; }
        public decimal? Lng { get; set; }
        public DateTime Createdate { get; set; }
        public bool Isapprove { get; set; }
        public string Bpcode { get; set; }
        public string Branchcode { get; set; }
        public string Addrno { get; set; }
        public string Street { get; set; }
        public string Subdistrict { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
        public string Zipcode { get; set; }
        public string Country { get; set; }
        public int? Radius { get; set; }
        public bool? Isdefault { get; set; }
        public bool? Isactive { get; set; }
        public bool? Activestate { get; set; }
        public bool? IsVerify { get; set; }
        public string Servicetime { get; set; }
        public bool? Isfind { get; set; }
        public string Skillpoi { get; set; }
        public int? Truckavailable { get; set; }
        public bool? IsException { get; set; }
    }
}
