using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>();
            string resourcesKey = Console.ReadLine();

            while(resourcesKey != "stop")
            {
                int quontity = int.Parse(Console.ReadLine());
                if (!items.ContainsKey(resourcesKey))
                {
                    items[resourcesKey] = 0;
                }
                items[resourcesKey] += quontity;
                resourcesKey = Console.ReadLine();
            }
            foreach (var curResources in items)
            {
                Console.WriteLine($"{curResources.Key} -> {curResources.Value}");
            }
        }
    }
}
