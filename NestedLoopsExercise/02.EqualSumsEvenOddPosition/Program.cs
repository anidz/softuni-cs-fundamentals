using System;

namespace _02.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for(int number = firstNumber; number <= secondNumber; number++)
            {
                int stThousands = number / 100000;
                int tenThousands = number / 10000 % 10;
                int thousands = number / 1000 % 10;
                int hundreds = number / 100 % 10;
                int tens = number / 10 % 10;
                int units = number % 10;

                if(stThousands + thousands + tens == tenThousands + hundreds + units)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
