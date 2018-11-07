using System;
using System.Collections.Generic;

namespace A2.Models
{
    public partial class Comment
    {
        public string CommentId { get; set; }
        public string StudentId { get; set; }
        public string EmpId { get; set; }
        public string Details { get; set; }

        public Staff Emp { get; set; }
        public Student Student { get; set; }
    }
}
