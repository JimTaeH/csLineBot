using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class OrderType
    {
        public OrderType()
        {
            PreOrders = new HashSet<PreOrder>();
        }

        public int No { get; set; }
        public string OrderTypeId { get; set; }
        public string OrderTypeName { get; set; }

        public virtual ICollection<PreOrder> PreOrders { get; set; }
    }
}
