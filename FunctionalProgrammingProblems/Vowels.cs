using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    public static class Vowels
    {
        public static void VowelAndConstant()
        {
            Console.Write("Enter an Alphabet: ");
            char ch = char.Parse(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + " Is a vowel");
            }
            else
            {
                Console.WriteLine(ch + " Is a Constant");
            }
        }
    }
}
