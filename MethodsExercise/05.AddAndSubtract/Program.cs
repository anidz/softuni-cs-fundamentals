﻿using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int result = Add(num1, num2);
            Substract(result, num3);
        }
        private static int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        private static void Substract(int result, int num3)
        {
            Console.WriteLine(result - num3);
        }
    }
}
