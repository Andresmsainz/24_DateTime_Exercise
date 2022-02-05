using System;

namespace _24_DateTime_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Date Time Exercise!");
            Console.WriteLine("");
            DateTime myDate = DateTime.Now;

            Console.WriteLine("First Format 30-09-2017 09:09:59");
            Console.WriteLine("myDate variable = {0:dd-MM-yyyy HH:mm:ss}", myDate);
            Console.WriteLine("myDate variable = " +  myDate.ToString("dd-MM-yyyy HH:mm:ss"));

            Console.WriteLine("");

            Console.WriteLine("Second Format Friday of month September year 2017");
            Console.WriteLine("myDate variable = {0:dddd} of month {0:MMMM} year {0:yyyy}", myDate);
            Console.WriteLine("myDate variable = " + myDate.ToString("dddd") + " of month " + myDate.ToString("MMMM") + " year " + myDate.ToString("yyyy"));

            Console.WriteLine("");

            Console.WriteLine("Third Format = \n Day Friday \n Month September \n Year 2017");
            Console.WriteLine("myDate variable = \n Day {0:dddd} \n Month {0:MMMM} \n Year {0:yyyy}", myDate);
            Console.WriteLine("myDate variable = " + "\n Day " + myDate.ToString("dddd") + "\n Month " + myDate.ToString("MMMM") + "\n Year " + myDate.ToString("yyyy"));

        }
    }
}
