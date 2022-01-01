﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroRecruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> spellBook = new Dictionary<string, List<string>>();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] element = command.Split();

                if (element[0] == "Enroll")
                {
                    string heroName = element[1];

                    if (!spellBook.ContainsKey(heroName))
                    {
                        spellBook[heroName] = new List<string>();
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                }
                else if (element[0] == "Learn")
                {
                    string heroName = element[1];
                    string spellName = element[2];

                    if (spellBook.ContainsKey(heroName))
                    {
                        if (!spellBook[heroName].Contains(spellName))
                        {
                            spellBook[heroName].Add(spellName);
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} has already learnt {spellName}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }

                }
                else if (element[0] == "Unlearn")
                {
                    string heroName = element[1];
                    string spellName = element[2];

                    if (spellBook.ContainsKey(heroName))
                    {
                        if (spellBook[heroName].Contains(spellName))
                        {
                            spellBook[heroName].Remove(spellName);
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} doesn't know {spellName}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                }
            }

            Console.WriteLine("Heroes:");

            foreach (var hero in spellBook.OrderByDescending(v => v.Value.Count()).ThenBy(k => k.Key))
            {
                Console.Write($"== {hero.Key}:");

                int count = 0;

                foreach (var kvp in hero.Value)
                {
                    count++;
                    if (count == hero.Value.Count())
                    {
                        Console.Write($" {kvp}");
                    }
                    else
                    {
                        Console.Write($" {kvp},");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
