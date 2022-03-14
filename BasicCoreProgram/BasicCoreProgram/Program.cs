namespace BasicCoreProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice");
            Console.WriteLine("1 = FlipCoin");
            Console.WriteLine("2 = LeapYear");
            int ch = int.Parse(Console.ReadLine());

            switch (ch) {
                case 1:
                    FlipCoin fc = new FlipCoin();
                    fc.Display();
                    break;
                case 2:
                    LeapYear ly = new LeapYear();
                    ly.Leap();
                    break;
        }

        }
    }
}