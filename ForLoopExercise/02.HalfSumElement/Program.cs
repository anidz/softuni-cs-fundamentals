using System;

namespace _02.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;

            for (int number = 1; number <= n; number++)
            {
                int value = int.Parse(Console.ReadLine());
                sum += value;
                if (value > max)
                {
                    max = value;
                }
            }

                int sumOther = sum - max;
                if (sumOther == max)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine($"Sum = {max}");
                }
                else
                {
                    Console.WriteLine("No");
                    Console.WriteLine($"Diff = {Math.Abs(max - sumOther)}");
                }
            
        }
    }
}
