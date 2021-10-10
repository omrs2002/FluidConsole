using System;
using System.Collections.Generic;
using Fluid;
using Fluid.Values;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FluidConsoleApp
{



    partial class Program
    {
        static void Main(string[] args)
        {

            //TestSimpleTemplate();
            //TestGOSItemplate();
            //TestNICVerifyTemplate();
            //TestMC();
            //TestCompanyVerify();
            testGenerics test = new testGenerics();


        }

        static void TestNICVerifyTemplate()
        {

            string temp = Templates.NICVerifyTemplate();
            var parser = new FluidParser();
            string big_json = System.IO.File.ReadAllText("C:\\My Projects\\FluidConsole\\FluidConsoleApp\\Entities\\NIC\\NICVerify.json");
            string sm = temp;
            string cres = FluidHelper.FluidMapper(big_json, sm);
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("FluidConsoleApp.dll", "VerifyNIC.json");
            System.IO.File.WriteAllText(path, cres);
            Console.WriteLine("Again (Y/N):");
            var r = Console.ReadLine();
            if (r.ToUpper() == "Y")
            {
                TestGOSItemplate();
            }


        }
    
        static void TestMC()
        {

            string temp = Templates.MCTemplate();
            var parser = new FluidParser();
            string big_json = System.IO.File.ReadAllText("C:\\My Projects\\FluidConsole\\FluidConsoleApp\\Entities\\NIC\\NICVerify.json");
            string sm = temp;
            string cres = FluidHelper.FluidMapper(big_json, sm);
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("FluidConsoleApp.dll", "MC.json");
            System.IO.File.WriteAllText(path, cres);
            Console.WriteLine("Again (Y/N):");
            var r = Console.ReadLine();
            if (r.ToUpper() == "Y")
            {
                TestGOSItemplate();
            }


        }

        static void TestCompanyVerify()
        {
            string temp = Templates.NicVerifyCompanyTemplate();
            var parser = new FluidParser();
            string big_json = System.IO.File.ReadAllText("C:\\My Projects\\FluidConsole\\FluidConsoleApp\\Json\\Companies\\BroadCastDTO.json");
            string sm = temp;
            string cres = FluidHelper.FluidMapper(big_json, sm);
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("FluidConsoleApp.dll", "NIC Company Verify.json");
            System.IO.File.WriteAllText(path, cres);
            Console.WriteLine("Again (Y/N):");
            var r = Console.ReadLine();
            if (r.ToUpper() == "Y")
            {
                TestCompanyVerify();
            }


        }

        static void TestGOSItemplate()
        {
            string temp = Templates.GosiTemplate();
            var parser = new FluidParser();
            string big_json = System.IO.File.ReadAllText("C:\\My Projects\\FluidConsole\\FluidConsoleApp\\Entities\\NIC\\big_json.json");
            string sm = temp;
            string cres = FluidHelper.FluidMapper(big_json, sm);
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("FluidConsoleApp.dll", "Gosi.json");
            System.IO.File.WriteAllText(path, cres);
            Console.WriteLine("Again (Y/N):");
            var r = Console.ReadLine();
            if (r.ToUpper() == "Y")
            {
                TestCompanyVerify();
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
