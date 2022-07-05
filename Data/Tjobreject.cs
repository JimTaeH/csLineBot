using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Data
{
    public partial class Tjobreject
    {
        public int Id { get; set; }
        public string Jobno { get; set; }
        public string Reasoncode { get; set; }
        public DateTime? Dduedate { get; set; }
        public DateTime? Checkindate { get; set; }
        public string Checkinlatlng { get; set; }
        public string Shortname { get; set; }
        public string Fullname { get; set; }
        public string Hhid { get; set; }
        public DateTime? Cdate { get; set; }
        public string Remark { get; set; }
    }
}
