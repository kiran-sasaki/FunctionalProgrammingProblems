using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    public static class GreatestNo
    {
        public static void FindMaximum()
        {
            int num1, num2, num3;
            Console.WriteLine("Find the largest of three numbers:");

            Console.Write("Input the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.Write("The {0} is the greater Then {1} and {2}. \n\n", num1,num2,num3);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.Write("The {0} is the greater Then {1} and {2}. \n\n", num2,num3,num1);
            }
            if (num3 > num2 && num3 > num1)
            {
                Console.Write("The {0} is the greater Then {1} and {2}. \n\n", num3,num2,num1);
            }
        }
    }
}
