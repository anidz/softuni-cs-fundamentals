﻿using System;

namespace _05.SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("+");
            for(int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
            for(int row = 0; row < n - 2; row++)
            {
                Console.Write("|");
                for(int i = 0; i < n - 2; i++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }
            Console.Write("+");
            for(int i = 0; i < n - 2; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
        }
    }
}
