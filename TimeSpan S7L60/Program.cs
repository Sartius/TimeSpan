using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpan_S7L60
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating timespan objects
            var timespan = new TimeSpan(1, 2, 3);
            var timespan1 = new TimeSpan(1, 0, 0);
            var timespan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;

            Console.WriteLine("Duration: " + duration);

            //properties
            Console.WriteLine("Minutes: " + timespan.Minutes);
            Console.WriteLine("Total minutes: " + timespan.TotalMinutes);

            //Add 

            Console.WriteLine("Add example: " + timespan.Add(TimeSpan.FromMinutes(8)));

            Console.WriteLine("Subtract example: " + timespan.Subtract(TimeSpan.FromMinutes(2)));

            //To/From string conversion
            Console.WriteLine("ToString: " + timespan.ToString());

            //Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
