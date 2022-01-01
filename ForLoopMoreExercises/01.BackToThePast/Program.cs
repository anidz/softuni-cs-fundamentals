using System;

namespace _01.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int age = 17;
            for (int i = 1800; i <= n; i++)
            {

                if (i % 2 == 0)
                {
                    age += 1;
                    money -= 12000;
                }
                else
                {
                    age += 1;
                    money -= 12000 + (age * 50);
                }
            }
            if (money >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left.");
                
            }
            else
            {
                double neededMoney = Math.Abs(money);
                Console.WriteLine($"He will need {neededMoney:f2} dollars to survive.");
                
            }
        }
    }
}
