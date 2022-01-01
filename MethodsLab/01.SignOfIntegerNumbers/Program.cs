using System;

namespace _01.SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);

        }

        public static void PrintSign(int n)
        {
            if (n > 0)
            {
               Console.WriteLine("The number {0} is positive.", n);
            }
            else if (n == 0)
            {
                
                Console.WriteLine("The number {0} is zero.", n);
            }
            else if (n < 0)

            {
                
                Console.WriteLine("The number {0} is negative.", n);
            }
        }
    }
}
