using System;
using System.Collections.Generic;

#nullable disable

namespace MyLineBot.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
