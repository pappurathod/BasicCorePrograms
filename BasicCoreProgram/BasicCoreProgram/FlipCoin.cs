using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class FlipCoin
    {
        public double Headper = 0;
        public double Tailper = 0;
        public int Head = 0;
        public int Tail = 0;

        public void Display()
        {
            Console.WriteLine("Enter the how many number of time to flip coin");
            int times = int.Parse(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                Random random = new Random();
                int toss = random.Next(0, 2);
                if (toss == 0)
                {
                    Head++;
                }
                if (toss == 1)
                {
                    Tail++;
                }

            }
            Headper = ((double)Head / times * 100);
            Console.WriteLine("Total Head = " + Head + ", Percentage of Heads = " + Headper);

            Tailper = ((double)Tail / times * 100);
            Console.WriteLine("Total Tail = " + Tail + ", Percentage of Tails = " + Tailper);
        }

    }
}
