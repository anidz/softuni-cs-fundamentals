﻿using System;

namespace StringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] element = command.Split();

                if (element[0] == "Translate")
                {
                    char letter = char.Parse(element[1]);
                    char replacement = char.Parse(element[2]);

                    input = input.Replace(letter, replacement);
                    Console.WriteLine(input);
                }
                else if (element[0] == "Includes")
                {
                    string word = element[1];
                    if (input.Contains(word))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (element[0] == "Start")
                {
                    string word = element[1];

                    if (input.StartsWith(word))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }

                }
                else if (element[0] == "Lowercase")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                else if (element[0] == "FindIndex")
                {
                    char letter = char.Parse(element[1]);
                    Console.WriteLine(input.LastIndexOf(letter));
                }
                else if (element[0] == "Remove")
                {
                    int startIndex = int.Parse(element[1]);
                    int count = int.Parse(element[2]);

                    input = input.Remove(startIndex, count);
                    Console.WriteLine(input);
                }
            }
        }
    }
}
