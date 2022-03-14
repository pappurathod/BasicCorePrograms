using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class QuotientReminder
    {
        public void Quotient()
        {
            Console.WriteLine("enter number Devident");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number Devisor");
            int num2 = int.Parse(Console.ReadLine());
            int quo = num1 / num2;
            int reminder = num1 % num2;

            Console.WriteLine("Quotient is " + quo + ", Reminder is " + reminder);
        }

    }
}
