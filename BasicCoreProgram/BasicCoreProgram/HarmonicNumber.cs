using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class HarmonicNumber
    {

        public void Harmonic()
        {
            double sum = 0;
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.Write("1/{0} + ", i);
                sum += 1 / (float)i;
            }
            Console.Write("\n");
            Console.WriteLine("sum is = " + sum);
        }
    }
}
