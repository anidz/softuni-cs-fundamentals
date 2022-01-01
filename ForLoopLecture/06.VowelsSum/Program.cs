using System;

namespace _06.VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int length = word.Length;
            int sum = 0;

            for(int value = 0; value <= length - 1; value ++)
            {
                
                char letter = word[value];
                switch (letter)
                {
                    case'a':
                        sum += 1;
                        break;
                    case'e':
                        sum += 2;
                        break;
                    case'i':
                        sum += 3;
                        break;
                    case'o':
                        sum += 4;
                        break;
                    case'u':
                        sum += 5;
                        break;
                }

                
            }
            Console.WriteLine(sum);
        }
    }
}
