using System;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num >= 3 && num <= 100)
            {
                if (num % 2 == 1) 
                {
                    int beg = num / 2;
                    Console.WriteLine("{0}*{0}", new string('-', beg));
                    for (int raw = beg - 1; raw >= (-beg + 1); raw--)
                    {
                        int rawAbs = Math.Abs(raw);
                        Console.WriteLine("{0}*{1}*{0}", new string('-', rawAbs), new string('-', (1 + (beg - rawAbs - 1) * 2)));
                    }
                    Console.WriteLine("{0}*{0}", new string('-', beg));
                }

                else 
                {
                    int beg = (num - 1) / 2;

                    for (int raw = beg; raw >= (-beg); raw--)
                    {
                        int rawAbs = Math.Abs(raw);
                        Console.WriteLine("{0}*{1}*{0}", new string('-', rawAbs), new string('-', (beg - rawAbs) * 2));
                    }
                }
            }
            else if (num == 1 || num == 2)
            {
                Console.WriteLine("{0}", new string('*', num));
            }
        }
    }
}
