using System;

namespace _07.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfRows = int.Parse(Console.ReadLine());
            int totalSum = 0;
            for(int i = 0; i < numOfRows; i ++)
            {
                int number = int.Parse(Console.ReadLine());
                totalSum += number;
            }
            Console.WriteLine(totalSum);
        }
    }
}
