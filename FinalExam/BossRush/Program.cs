﻿using System;
using System.Text.RegularExpressions;

namespace BossRush
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Regex pattern = new Regex(@"\|([A-Z]{4,})\|:#([A-Za-z]+ [A-Za-z]+)#");

                Match match = pattern.Match(input);

                if (match.Success)
                {
                    Console.WriteLine($"{match.Groups[1].Value}, The {match.Groups[2].Value}");
                    Console.WriteLine($">> Strength: {match.Groups[1].Value.Length}");
                    Console.WriteLine($">> Armour: {match.Groups[2].Value.Length}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
