using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class TicketDetail
    {
        public TicketDetail()
        {
            TicketMessages = new HashSet<TicketMessage>();
            TicketUploads = new HashSet<TicketUpload>();
        }

        public int Id { get; set; }
        public string TicketId { get; set; }
        public string WhoProblem { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public string CreateBy { get; set; }
        public int Level { get; set; }
        public int Status { get; set; }
        public string AgentRoleId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string PrivateSolution { get; set; }
        public int TelContact { get; set; }
        public int? ScoreFeedback { get; set; }
        public string AdviceFeedback { get; set; }

        public virtual ICollection<TicketMessage> TicketMessages { get; set; }
        public virtual ICollection<TicketUpload> TicketUploads { get; set; }
    }
}
