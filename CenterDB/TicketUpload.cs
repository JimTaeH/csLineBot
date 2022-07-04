using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class TicketUpload
    {
        public int Id { get; set; }
        public int ForId { get; set; }
        public string TicketId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string PathAddress { get; set; }

        public virtual TicketDetail For { get; set; }
    }
}
