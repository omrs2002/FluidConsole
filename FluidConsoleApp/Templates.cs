using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluidConsoleApp
{
    public static class Templates
    {

        public static string SimpleTemplateFromStudent()
        {
            return @"Hello {{ Firstname }} {{ Lastname }}
            {% for course in StudentCourses %}
                {% if Firstname %} {{Firstname}} registered in {{course.CourseName }} course.
                {% endif %}
                {% if forloop.last == true %}
                This is the last loop!
                {% endif %}
            {% endfor %}
            
            {% assign mydate = StartDate | date: '%s' %}
            Date in UTC: {{ mydate   }}
            Date: {{ StartDate | date: '%d-%m-%Y'  }}

            
            After Adding 5 Days:
            
            {% assign days = 365 | times: 86400 %}
            {{ StartDate | date: '%s' | plus: days | date: '%d-%m-%Y' }}

            adding 3 days to now date:
            {% assign days = 3 | times: 86400 %}
            {{ 'now' | date: '%s' | plus: days | date: '%d-%m-%Y' }}
            
            adding 3 years now date:
            {% assign years = 3 | times: 365 | times: 86400 %}
            {{ 'now' | date: '%s' | plus: years | date: '%d-%m-%Y' }}
            ";
        } 
        internal static string GosiTemplate()
        {

            return System.IO.File.ReadAllText("C:\\My Projects\\FluidConsole\\FluidConsoleApp\\Json\\GOSI.liquid"); ;
        }
   internal static string NicVerifyCompanyTemplate()
        {
            return System.IO.File.ReadAllText("C:\\My Projects\\FluidConsole\\FluidConsoleApp\\Json\\Companies\\NICValidate.liquid"); ;
        }
        internal static string MCTemplate()
        {
            return System.IO.File.ReadAllText("C:\\My Projects\\FluidConsole\\FluidConsoleApp\\Json\\MC Template.liquid"); ;
        }

        public static string GOSITemplate()
        {
            string GOSItemplate = System.IO.File.ReadAllText("C:\\My Projects\\FluidConsole\\FluidConsoleApp\\Json\\GOSI.liquid");
            return GOSItemplate;
        }

        public static string NICVerifyTemplate()
        {
            string GOSItemplate = System.IO.File.ReadAllText("C:\\My Projects\\FluidConsole\\FluidConsoleApp\\Json\\NIC Template.liquid");
            return GOSItemplate;
        }


    }
}
