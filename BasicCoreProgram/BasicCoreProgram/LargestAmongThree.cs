using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class LargestAmongThree
    {

        public void Largest()
        {
            Console.WriteLine("enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter third number");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("max number is " + num1);

            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("max number is " + num2);

            }
            else
            {
                Console.WriteLine("max number is " + num3);

            }

        }
    }
}
