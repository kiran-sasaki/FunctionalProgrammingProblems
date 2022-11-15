using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    public static class PowerOf2
    {
        public static void Exponent()
        {
            double result;
            Console.WriteLine("Enter The Power");
            int Power = int.Parse(Console.ReadLine());
            int a = 2;
            for (int i = 0; i <= Power; i++)
            {
                result = Math.Pow(a, i);
                Console.WriteLine(a + " power of " + i + " is " + result);
            }
        }
    }
}
