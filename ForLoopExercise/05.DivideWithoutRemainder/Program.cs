using System;

namespace _05.DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countGroup1 = 0;
            int countGroup2 = 0;
            int countGroup3 = 0;

            for(int number =1; number <= n; number++)
            {
                int value = int.Parse(Console.ReadLine());
                if(value % 2 == 0)
                {
                    countGroup1++;
                }
                if(value % 3 == 0)
                {
                    countGroup2++;
                }
                if(value % 4 == 0)
                {
                    countGroup3++;
                }
            }
            double percent1 = countGroup1 * 1.0 / n * 100;
            double percent2 = countGroup2 * 1.0 / n * 100;
            double percent3 = countGroup3 * 1.0 / n * 100;
            

            Console.WriteLine($"{percent1:f2}%");
            Console.WriteLine($"{percent2:f2}%");
            Console.WriteLine($"{percent3:f2}%");
            
        }
    }
}
