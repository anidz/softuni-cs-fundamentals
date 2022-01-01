using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string splited = String.Empty;

            while (splited != "Finish")
            {
                splited = Console.ReadLine();

                string[] action = splited.Split().ToArray();

                if (action[0] == "Add")
                {
                    int numberToAdd = int.Parse(action[1]);
                    numbers.Add(numberToAdd);
                }
                else if (action[0] == "Remove")
                {
                    int numberToRemove = int.Parse(action[1]);
                    numbers.Remove(numberToRemove);
                }
                else if (action[0] == "Replace")
                {
                    int numberToDelete = int.Parse(action[1]);
                    int numberToInsert = int.Parse(action[2]);

                    if (numbers.Contains(numberToDelete))
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == numberToDelete)
                            {
                                numbers.Insert(i, numberToInsert);
                                numbers.RemoveAt(i + 1);
                                break;
                            }
                        }
                    }
                }
                else if (action[0] == "Collapse")
                {
                    int limitValue = int.Parse(action[1]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] < limitValue)
                        {
                            numbers.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
        
    

