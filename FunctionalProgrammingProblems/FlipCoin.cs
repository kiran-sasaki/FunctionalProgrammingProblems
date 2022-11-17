using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgrammingProblems
{
    public static class FlipCoin
    {
        public static void HeadOrTailPercentage()
        {
            int tailCount = 0;
            int headCount = 0;
            Double headPercentage = 0;
            Double tailPercentage = 0;

            Console.WriteLine("Enter The No Of times to Flips");
            int flips = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < flips; i++)
            {
                Random random = new Random();
                int num = random.Next(2);

                if (num == 0)
                {
                    Console.WriteLine("Tail");
                    tailCount++;
                }
                else
                {
                    Console.WriteLine("Head");
                    headCount++;
                }
            }
            HeadPercentage = (HeadCount * 100) / flips;
            TailPercentage = (TailCount * 100) / flips;
            Console.WriteLine("tailpercentage " + TailPercentage);
            Console.WriteLine("headpercentage " + HeadPercentage);
        }
    }
}
