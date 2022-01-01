using System;

namespace _02.PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int[] reversedArray = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[array.Length - i - 1];
            }

            for (int i = 0; i < reversedArray.Length; i++)
            {
                Console.Write(reversedArray[i] + " ");
            }

        }
    }
}
