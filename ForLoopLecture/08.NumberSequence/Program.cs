﻿using System;

namespace _08.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfRows = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            for(int i = 0; i < numOfRows; i ++)
            {
                int number = int.Parse(Console.ReadLine());
                if(number > maxNumber)
                {
                    maxNumber = number;
                }
                if(number < minNumber)
                {
                    minNumber = number;
                }
                
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}