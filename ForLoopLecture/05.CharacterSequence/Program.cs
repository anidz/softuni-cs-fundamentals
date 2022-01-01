using System;

namespace _05.CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int length = word.Length;
            for(int value = 0; value <= length -1; value ++)
            {
                Console.WriteLine($"{word[value]}");
            }
        }
    }
}
