﻿using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int person = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double courses = Math.Ceiling((double)person / capacity);

            Console.WriteLine(courses);
        }
    }
}
