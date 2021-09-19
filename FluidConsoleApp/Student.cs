using System;
using System.Collections.Generic;

namespace FluidConsoleApp
{
    partial class Program
    {
        public class Student
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }

            public DateTime StartDate { get; set; }

            public IList<Course> StudentCourses { get; set; }

        }
    }
}
