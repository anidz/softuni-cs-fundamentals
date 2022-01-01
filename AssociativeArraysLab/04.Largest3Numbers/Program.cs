using System;
using System.Linq;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split()
                .Select(int.Parse).OrderByDescending(x => x).ToArray();

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    Console.Write($"{nums[i]} ");
                }
                catch (Exception)
                {
                    break;
                }
            }
        }
    }
}
