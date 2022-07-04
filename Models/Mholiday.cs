using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Mholiday
    {
        public int No { get; set; }
        public string Poireceive { get; set; }
        public string Poidelivery { get; set; }
        public string Poideliverytype { get; set; }
        public string Description { get; set; }
        public string Bpcode { get; set; }
        public string HolidayDow { get; set; }
        public string RegularFlag { get; set; }
        public DateTime? Holiday { get; set; }
        public string TimeFrom { get; set; }
        public string TimeTo { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUser { get; set; }
    }
}
