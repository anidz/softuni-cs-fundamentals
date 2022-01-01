﻿using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            double result1 = Factorial(firstNum);
            double result2 = Factorial(secondNum);
            Console.WriteLine($"{result1 / result2:F2}");
        }

        private static double Factorial(int number)
        {
            double result = 1;
            while(number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }
    }
}
