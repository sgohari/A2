using System;
using System.Collections.Generic;

namespace A2.Models
{
    public partial class Course
    {
        public string CourseCode { get; set; }
        public string StudentId { get; set; }
        public string StaffId { get; set; }
        public string CourseTitle { get; set; }

        public Staff Staff { get; set; }
        public Student Student { get; set; }
    }
}
