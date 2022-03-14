using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class LeapYear
    {
        public void Leap()
        {
            Console.WriteLine("Enter year");
            int year = int.Parse(Console.ReadLine());
            if (year > 999 && year < 10000)
            {
                if (DateTime.IsLeapYear(year))
                {
                    Console.WriteLine("{0} is Leap year", year);
                }
                else
                {
                    Console.WriteLine("{0} is not Leap year", year);
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Enter valid 4 digit year");
            }
        }

    }
}
