using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class TicketMessage
    {
        public int Id { get; set; }
        public int ForId { get; set; }
        public string TicketId { get; set; }
        public string Sender { get; set; }
        public string Message { get; set; }

        public virtual TicketDetail For { get; set; }
    }
}
