using System;
using System.Collections.Generic;
using Fluid;

namespace FluidConsoleApp
{
    class Program
    {
        public class Course
        {
            public string CourseName { get; set; }
        }

        public class Student
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }

            public IList<Course> StudentCourses { get; set; }

        }
        static void Main(string[] args)
        {
            var parser = new FluidParser();
            
          

            Student model = new() { Firstname = "Omar", Lastname = "Abuhadid"};
            

            model.StudentCourses = new List<Course>
            {
                new Course { CourseName = "English" },
                new Course { CourseName = "Math" },
                new Course { CourseName = "Science" }
            };

            // you are resistered in 
            var source = @"Hello {{ Firstname }} {{ Lastname }}
            {% for course in StudentCourses %}
            {{Firstname}} registered in {{course.CourseName }} course
            {% endfor %}
            ";


            var options = new TemplateOptions();
            options.MemberAccessStrategy.Register<Student>();
            options.MemberAccessStrategy.Register<Course>();
            options.MemberAccessStrategy.Register<List<Course>>();

            if (parser.TryParse(source, out var template, out var error))
            {
                var context = new TemplateContext(model, options,true);
                Console.WriteLine(template.Render(context));
            }
            else
            {
                Console.WriteLine($"Error: {error}");
            }
            Console.WriteLine("Again (Y/N):");
            var r = Console.ReadLine();
            if(r.ToUpper() == "Y")
            {
                Main(args);
            }
        }
    }
}
