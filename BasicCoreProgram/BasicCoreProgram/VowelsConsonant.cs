using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class VowelsConsonant
    {

        public void WovelConso()
        {
            Console.WriteLine("enter charector");
            char ch = char.Parse(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("The {0} Alphabet is Vowel", ch);
                    break;
                case 'e':
                    Console.WriteLine("The {0} Alphabet is Vowel", ch);
                    break;
                case 'i':
                    Console.WriteLine("The {0} Alphabet is Vowel", ch);
                    break;
                case 'o':
                    Console.WriteLine("The {0} Alphabet is Vowel", ch);
                    break;
                case 'u':
                    Console.WriteLine("The {0} Alphabet is Vowel", ch);
                    break;
                default:
                    Console.WriteLine("The {0} Alphabet is Consonant", ch);
                    break;


            }
        }
    }
}
