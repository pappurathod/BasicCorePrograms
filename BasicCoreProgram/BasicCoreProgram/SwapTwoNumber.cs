using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class SwapTwoNumber
    {

        public void Swap()
        {

            Console.WriteLine("enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int num2 = int.Parse(Console.ReadLine());
            int temp = 0;

            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After swap \nnumber1 is = " + num1 + "\nnumber2 is = " + num2);

        }
    }
}
