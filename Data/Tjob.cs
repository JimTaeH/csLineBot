using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Data
{
    public partial class Tjob
    {
        public string Jobno { get; set; }
        public int Jobtype { get; set; }
        public string Poireceive { get; set; }
        public string Poidelivery { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public string Remark { get; set; }
        public string Groupid { get; set; }
        public string Hhid { get; set; }
        public string Jobstatus { get; set; }
        public DateTime Cdate { get; set; }
        public string Cby { get; set; }
        public DateTime? Ddate { get; set; }
        public DateTime? Rdate { get; set; }
        public bool? Ispriority { get; set; }
        public int? Contactr { get; set; }
        public int? Contactd { get; set; }
        public string Bpcode { get; set; }
        public string Attachfile { get; set; }
        public string Attachname { get; set; }
        public string Rsignimg { get; set; }
        public string Dsignimg { get; set; }
        public string Rmanimg { get; set; }
        public string Dmanimg { get; set; }
        public DateTime? Rduedate { get; set; }
        public DateTime? Dduedate { get; set; }
        public decimal? Rlat { get; set; }
        public decimal? Rlng { get; set; }
        public decimal? Dlat { get; set; }
        public decimal? Dlng { get; set; }
        public DateTime? Printdate { get; set; }
        public string Rqr { get; set; }
        public string Dqr { get; set; }
        public double? Rdistance { get; set; }
        public double? Ddistance { get; set; }
        public string UpdateBy { get; set; }
        public bool? IsApprove { get; set; }
        public string Approveby { get; set; }
        public double? Payamount { get; set; }
        public DateTime? Paydate { get; set; }
        public string Payref { get; set; }
        public DateTime? Approvedate { get; set; }
        public int? Seq { get; set; }
        public DateTime? Epdate { get; set; }
        public DateTime? Ackdate { get; set; }
        public DateTime? Ackduedate { get; set; }
        public string Ackstatus { get; set; }
        public DateTime? Rchkindate { get; set; }
        public string Rchkinlatlng { get; set; }
        public DateTime? Rchkoutdate { get; set; }
        public string Rchkoutlatlng { get; set; }
        public DateTime? Dchkindate { get; set; }
        public string Dchkinlatlng { get; set; }
        public DateTime? Dchkoutdate { get; set; }
        public string Dchkoutlatlng { get; set; }
        public bool? Recognize { get; set; }
        public DateTime? RecognizeDate { get; set; }
        public string LoadId { get; set; }
        public int? LoadOrder { get; set; }
        public int? VerifyByContact { get; set; }
        public decimal? Amount { get; set; }
        public string Ref5 { get; set; }
        public string Ref6 { get; set; }
        public string Ref7 { get; set; }
        public string Ref8 { get; set; }
        public string Ref9 { get; set; }
        public string Ref10 { get; set; }
        public string Ref11 { get; set; }
        public string Ref12 { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? ReceiveUpdateDate { get; set; }
        public DateTime? DeliveryUpdateDate { get; set; }
        public DateTime? Eta { get; set; }
        public double? Tdistance { get; set; }
        public double? Ttime { get; set; }
        public string Zone { get; set; }
        public string JobSkill { get; set; }
    }
}
