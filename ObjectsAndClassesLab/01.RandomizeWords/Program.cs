using System;

namespace _01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Random rnd = new Random();
            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                int pos2 = rnd.Next(words.Length);
                string a = words[pos2];
                string b = words[pos1];

                words[pos2] = b;
                words[pos1] = a;
            }
            foreach (string item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
