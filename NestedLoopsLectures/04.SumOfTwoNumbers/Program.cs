using System;

namespace _04.SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = int.Parse(Console.ReadLine());
            int finalNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combination = 0;
            bool isFound = false;

            for(int firstNumber = startingNumber; firstNumber <= finalNumber; firstNumber++)
            {
                for (int secondNumber = startingNumber; secondNumber <= finalNumber; secondNumber++)
                {
                    combination++;
                    if(firstNumber + secondNumber == magicNumber)
                    {
                        isFound = true;
                        Console.WriteLine($"Combination N:{combination} ({firstNumber} + {secondNumber} = {firstNumber + secondNumber})");
                        break;
                    }
                }
                if(isFound)
                {
                    return;
                }
            }
            Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");

        }
    }
}
