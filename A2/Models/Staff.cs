using System;
using System.Collections.Generic;

namespace A2.Models
{
    public partial class Staff
    {
        public Staff()
        {
            Comment = new HashSet<Comment>();
            CourseNavigation = new HashSet<Course>();
        }

        public string EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Course { get; set; }
        public string Department { get; set; }

        public ICollection<Comment> Comment { get; set; }
        public ICollection<Course> CourseNavigation { get; set; }
    }
}
