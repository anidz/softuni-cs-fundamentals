using System;

namespace _05.PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for(int firstElement = 1; firstElement <= n; firstElement++)
            {
                for(int secondElement = 1; secondElement <= n; secondElement++)
                {
                    for (char thirdElement = 'a'; thirdElement < 'a' + l; thirdElement++) 
                      {
                        for(char fourElement = 'a'; fourElement < 'a' + l; fourElement++)
                        {
                            for(int fifthElement = 1; fifthElement <= n; fifthElement++)
                            {
                                if(fifthElement > firstElement && fifthElement > secondElement)
                                {
                                    Console.Write($"{firstElement}{secondElement}{thirdElement}{fourElement}{fifthElement} ");
                                }
                            }
                        }

                       }
                }
            }
        }
    }
}
