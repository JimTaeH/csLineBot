using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Payment
    {
        public int No { get; set; }
        public string InvoiceNo { get; set; }
        public string UserId { get; set; }
        public string JobNo { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Vat { get; set; }
        public decimal? NetAmount { get; set; }
        public int? PaymentType { get; set; }
        public DateTime? PaymentDate { get; set; }
        public bool? PaymentStatus { get; set; }
        public DateTime? CreateDate { get; set; }
        public string RefCode { get; set; }
        public string Refer1 { get; set; }
        public string Refer2 { get; set; }
        public string Refer3 { get; set; }
        public string Refer4 { get; set; }
        public DateTime? PaymentEndDate { get; set; }
        public string RecordBy { get; set; }
    }
}
