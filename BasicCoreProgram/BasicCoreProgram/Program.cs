namespace BasicCoreProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice");
            Console.WriteLine("1 = FlipCoin");
            Console.WriteLine("2 = LeapYear");
            Console.WriteLine("3 = PowerOfTwo");
            Console.WriteLine("4 = Harmonic Number");
            Console.WriteLine("5 = Factor");
            Console.WriteLine("6 = QuotientReminder");
            Console.WriteLine("7 = Swap Two Numbers");
            Console.WriteLine("8 = Even Odd");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {             
            
                case 1:
                    FlipCoin fc = new FlipCoin();
                    fc.Display();
                    break;
                case 2:
                    LeapYear ly = new LeapYear();
                    ly.Leap();
                    break;


                case 3:
                    PowerOfTwo pot = new PowerOfTwo();
                    pot.PowerTwo();
                    break;
                case 4:
                    HarmonicNumber hn = new HarmonicNumber();
                    hn.Harmonic();
                    break;
                case 5:
                    Factor fact = new Factor();
                    fact.Factors();
                    break;
                case 6:
                    QuotientReminder quormdr = new QuotientReminder();
                    quormdr.Quotient();
                    break;
                case 7:
                    SwapTwoNumber swapnum = new SwapTwoNumber();
                    swapnum.Swap();
                    break;
                case 8:
                    EvenOdd evod = new EvenOdd();
                    evod.check();
                    break;
            }


        }


    }
}
