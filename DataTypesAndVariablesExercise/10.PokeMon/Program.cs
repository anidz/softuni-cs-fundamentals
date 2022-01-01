﻿using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int startingPower = power;
            int countOfPovedTargets = 0;

            while(power >= distance)
            {
                power -= distance;
                countOfPovedTargets++;
                if(startingPower * 0.5 == power && exhaustionFactor > 0)
                {
                    power /= exhaustionFactor;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(countOfPovedTargets);
        }
    }
}