using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Data.common
{
    public partial class Customer
    {
        public int No { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Gps { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public bool? Status { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? CleanDate { get; set; }
        public string ContractId { get; set; }
        public string CustomerCode { get; set; }
        public string EncryptKey { get; set; }
        public string CustomerAccountNo { get; set; }
        public string CompanyGroup { get; set; }
        public bool? WebHook { get; set; }
        public bool? Vrpadvance { get; set; }
        public bool? Shipment { get; set; }
        public bool? ShipmentInterface { get; set; }
        public bool? TrackTrace { get; set; }
        public string TrackTraceName { get; set; }
    }
}
