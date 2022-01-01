using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Phone
{
    class Program
    {
        static void Main(string[] args)


        {
            List<string> phones = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0];
                if (command == "Add")
                {
                    string phone = parts[1];
                    if (phones.Contains(phone))
                    {
                        continue;
                    }
                    else
                    {
                        phones.Add(phone);
                    }
                }
                else if (command == "Remove")
                {
                    string phone = parts[1];
                    if (phones.Contains(phone))
                    {
                        phones.Remove(phone);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Bonus phone")
                {
                    string[] newParts = parts[1].Split(":", StringSplitOptions.RemoveEmptyEntries);
                    string oldPhone = newParts[0];
                    string newPhone = newParts[1];

                    for (int i = 0; i < phones.Count; i++)
                    {
                        if (phones[i] == oldPhone)
                        {
                            int index = i;
                            phones.Insert(index + 1, newPhone);
                        }
                    }
                }
                else
                {
                    string phone = parts[1];
                    if (phones.Contains(phone))
                    {
                        phones.Remove(phone);
                        phones.Add(phone);
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", phones));
        }
    }
}



