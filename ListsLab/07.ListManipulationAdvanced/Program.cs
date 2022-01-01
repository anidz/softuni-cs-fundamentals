using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> basicList = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            changeTheList(input, basicList);
        }
        private static void changeTheList(string input, List<int> basicList)
        {
            int count = 0;
            while (input != "end")
            {
                string[] isolatedNumber = input.Split();

                switch (isolatedNumber[0])
                {
                    case "Add":
                        basicList.Add(int.Parse(isolatedNumber[1]));
                        count++;
                        break;
                    case "Remove":
                        basicList.Remove(int.Parse(isolatedNumber[1]));
                        count++;
                        break;
                    case "RemoveAt":
                        basicList.RemoveAt(int.Parse(isolatedNumber[1]));
                        count++;
                        break;
                    case "Insert":
                        int index = int.Parse(isolatedNumber[2]);
                        basicList.Insert(index, int.Parse(isolatedNumber[1]));
                        count++;
                        break;
                    default:
                        Console.WriteLine();
                        break;
                    case "Contains":
                        if (basicList.Contains(int.Parse(isolatedNumber[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        for (int i = 0; i <= basicList.Count - 1; i++)
                        {
                            if (basicList[i] % 2 == 0)
                            {
                                Console.Write($"{basicList[i]} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        for (int i = 0; i <= basicList.Count - 1; i++)
                        {
                            if (basicList[i] % 2 != 0)
                            {
                                Console.Write($"{basicList[i]} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        int summ = 0;
                        for (int i = 0; i <= basicList.Count - 1; i++)
                        {
                            summ += basicList[i];
                        }
                        Console.WriteLine(summ);
                        break;
                    case "Filter":
                        switch (isolatedNumber[1])
                        {
                            case "==":
                                for (int i = 0; i <= basicList.Count - 1; i++)
                                {
                                    if (basicList[i] == int.Parse(isolatedNumber[2]))
                                    {
                                        Console.Write($"{basicList[i]} ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case "!=":
                                for (int i = 0; i <= basicList.Count - 1; i++)
                                {
                                    if (basicList[i] != int.Parse(isolatedNumber[2]))
                                    {
                                        Console.Write($"{basicList[i]} ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case ">=":
                                for (int i = 0; i <= basicList.Count - 1; i++)
                                {
                                    if (basicList[i] >= int.Parse(isolatedNumber[2]))
                                    {
                                        Console.Write($"{basicList[i]} ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case ">":
                                for (int i = 0; i <= basicList.Count - 1; i++)
                                {
                                    if (basicList[i] > int.Parse(isolatedNumber[2]))
                                    {
                                        Console.Write($"{basicList[i]} ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case "<=":
                                for (int i = 0; i <= basicList.Count - 1; i++)
                                {
                                    if (basicList[i] <= int.Parse(isolatedNumber[2]))
                                    {
                                        Console.Write($"{basicList[i]} ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case "<":
                                for (int i = 0; i <= basicList.Count - 1; i++)
                                {
                                    if (basicList[i] < int.Parse(isolatedNumber[2]))
                                    {
                                        Console.Write($"{basicList[i]} ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            if (count != 0)
            {
                Console.Write(string.Join(" ", basicList));
            }
        }
    }
}
