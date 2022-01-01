﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> records = new Dictionary<string, List<int>>();

            string command;

            while ((command = Console.ReadLine()) != "Log out")
            {
                string[] element = command.Split(": ");

                if (element[0] == "New follower")
                {
                    string username = element[1];

                    if (!records.ContainsKey(username))
                    {
                        records.Add(username, new List<int>() { 0, 0 });
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (element[0] == "Like")
                {
                    string username = element[1];
                    int count = int.Parse(element[2]);

                    if (!records.ContainsKey(username))
                    {
                        records.Add(username, new List<int>() { count, 0 });
                    }
                    else
                    {
                        records[username][0] += count;
                    }
                }
                else if (element[0] == "Comment")
                {
                    string username = element[1];

                    if (!records.ContainsKey(username))
                    {
                        records.Add(username, new List<int>() { 0, 1 });
                    }
                    else
                    {
                        records[username][1]++;
                    }
                }
                else if (element[0] == "Blocked")
                {
                    string username = element[1];

                    if (records.ContainsKey(username))
                    {
                        records.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                }
            }

            Console.WriteLine($"{records.Count} followers");

            foreach (var item in records.OrderByDescending(v => v.Value[0]).ThenBy(k => k.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Sum()}");
            }
        }
    }
    }

