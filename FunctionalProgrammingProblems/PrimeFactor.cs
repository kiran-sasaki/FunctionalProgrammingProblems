using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    public static class PrimeFactor
    {
        public static void Factorization()
        {
            Console.WriteLine("Enter The Number");
            int num = int.Parse(Console.ReadLine());
            int i, j;
            int count = 0;
            int flag = 0;
            Console.Write("Prime factor of {0}:\n", num);
            for (i = 2; i < num; i++)
            {
                if(num%i == 0)
                {
                    count = 0;
                    for (j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                            count++;
                    }
                    if (count == 2)
                    {
                        flag = 1;
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
