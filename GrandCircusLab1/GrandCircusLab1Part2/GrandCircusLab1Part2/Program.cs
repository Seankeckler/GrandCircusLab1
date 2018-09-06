using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab1Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your first date MM/DD/YYYY ");
            string date1Str = Console.ReadLine();
            Console.WriteLine("Enter your second date MM/DD/YYYY");
            string date2Str = Console.ReadLine();

            DateTime date1 = DateTime.Parse(date1Str);
            DateTime date2 = DateTime.Parse(date2Str);

            TimeSpan ts = date2 - date1;
            Console.WriteLine("There are {0} days(s) or {1} hour(s) or {2} minute(s) between those dates", ts.TotalDays, ts.TotalHours, ts.TotalMinutes);

            Console.Read();
        }

    }
}
