using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var resultlist = new List<int>();


            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] >= 0)
                {
                    resultlist.Add(numbers[i]);
                }

            }
            if (resultlist.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", resultlist));

               

            }
        }
    }
}
