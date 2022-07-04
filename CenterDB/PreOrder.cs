using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class PreOrder
    {
        public PreOrder()
        {
            Licenses = new HashSet<License>();
        }

        public int No { get; set; }
        public string OrderId { get; set; }
        public string ReferenceCode { get; set; }
        public string TermStorage { get; set; }
        public string CustomerId { get; set; }
        public string UserId { get; set; }
        public string Remark { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public bool? IsApprove { get; set; }
        public string ApproveBy { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string State { get; set; }
        public int? Quantity { get; set; }
        public DateTime? LicenseStartDate { get; set; }
        public string OrderTypeId { get; set; }
        public string PeriodId { get; set; }
        public string AttachFileName { get; set; }
        public string AccountNo { get; set; }
        public string ChargingNo { get; set; }
        public string BillingPeriod { get; set; }
        public string CreditTerm { get; set; }
        public int? PackageClassId { get; set; }
        public int? PackageChannelId { get; set; }
        public int? PackageSimId { get; set; }
        public string SaleId { get; set; }
        public string RecSaleId { get; set; }
        public string AfterSaleId { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual OrderType OrderType { get; set; }
        public virtual ContractPeriod Period { get; set; }
        public virtual Period PeriodNavigation { get; set; }
        public virtual Account User { get; set; }
        public virtual ICollection<License> Licenses { get; set; }
    }
}
