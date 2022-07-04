using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Receipt
    {
        public string InvoiceNo { get; set; }
        public string ReceiptNo { get; set; }
        public string TerminalId { get; set; }
        public string MerchantId { get; set; }
        public string SystemTrace { get; set; }
        public string BatchId { get; set; }
        public string ReferenceNo { get; set; }
        public string ApprovalCode { get; set; }
    }
}
