using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class EvenOdd
    {

        public void check()
        {
            Console.WriteLine("enter first number");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("{0} is Even number", num);
            }
            else
            {
                Console.WriteLine("{0} is Odd number", num);
            }
        }
    }
}
