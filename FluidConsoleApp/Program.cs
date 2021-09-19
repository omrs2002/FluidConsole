using System;
using System.Collections.Generic;
using Fluid;
using FluidConsoleApp.Entities;

namespace FluidConsoleApp
{
    partial class Program
    {
        static void Main(string[] args)
        {

            //TestSimpleTemplate();
            TestGOSItemplate();


        }
        static void TestGOSItemplate()
        {
            string GosiTemplate = Templates.GOSITemplate();
            var parser = new FluidParser();

            SbcEstablishmentSummaryResponseModel Est = new()
            {
                CrInformation  = new CrInformation
                {
                    
                }
            };
            var source = Templates.GOSITemplate();
            var options = new TemplateOptions();
            options.MemberAccessStrategy.Register<SbcEstablishmentSummaryResponseModel>();

            if (parser.TryParse(source, out var template, out var error))
            {
                var context = new TemplateContext(Est, options);
                //Console.WriteLine(template.Render(context));
                System.IO.File.WriteAllText("C:\\My Projects\\FluidConsole\\FluidConsoleApp\\Json\\GOSI.json", template.Render(context));


            }
            else
            {
                Console.WriteLine($"Error: {error}");
            }
            Console.WriteLine("Again (Y/N):");
            var r = Console.ReadLine();
            if (r.ToUpper() == "Y")
            {
                TestGOSItemplate();
            }


        }
        static void TestSimpleTemplate()
        {
            var parser = new FluidParser();
            Student model = new() { Firstname = "Omar", Lastname = "Abuhadid", StartDate = DateTime.Today.Date.AddDays(30) };
            model.StudentCourses = new List<Course>
            {
                new Course { CourseName = "English" },
                new Course { CourseName = "Math" },
                new Course { CourseName = "Science" }
            };

            // you are resistered in 
            var source = Templates.SimpleTemplateFromStudent();
            var options = new TemplateOptions();
            options.MemberAccessStrategy.Register<Student>();
            options.MemberAccessStrategy.Register<Course>();

            if (parser.TryParse(source, out var template, out var error))
            {
                var context = new TemplateContext(model, options);
                Console.WriteLine(template.Render(context));
            }
            else
            {
                Console.WriteLine($"Error: {error}");
            }
            Console.WriteLine("Again (Y/N):");
            var r = Console.ReadLine();
            if (r.ToUpper() == "Y")
            {
                TestSimpleTemplate();
            }
        }
    }
}
