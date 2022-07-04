using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class ContractPeriod
    {
        public ContractPeriod()
        {
            PreOrders = new HashSet<PreOrder>();
        }

        public int No { get; set; }
        public string PeriodId { get; set; }
        public string PeriodName { get; set; }
        public string Unit { get; set; }
        public int Amount { get; set; }

        public virtual ICollection<PreOrder> PreOrders { get; set; }
    }
}
