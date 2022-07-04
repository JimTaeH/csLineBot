using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.CenterDB
{
    public partial class Content
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Contents { get; set; }
        public string Slug { get; set; }
        public string PermissionRole { get; set; }
        public DateTime? PublishDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? ViewCount { get; set; }
    }
}
