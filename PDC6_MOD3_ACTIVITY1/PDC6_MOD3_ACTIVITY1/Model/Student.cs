using System;
using System.Collections.Generic;
using System.Text;

namespace PDC6_MOD3_ACTIVITY1.Model
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }
        public int NumberOfUnits { get; set; }
        public DateTime DateOfAttendance { get; set; }
    }
}
