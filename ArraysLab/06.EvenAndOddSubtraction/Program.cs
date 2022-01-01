using System;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                if (currentNumber % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else if(currentNumber % 2 != 0)
                {
                    oddSum += currentNumber;
                }
            }
            int differene = evenSum - oddSum;
            Console.WriteLine(differene);

        }
    }
}
