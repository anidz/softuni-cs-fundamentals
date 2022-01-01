using System;

namespace _11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceOfLundry = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            double ageMoney = 10;
            double toysCount = 0;
            double totalSaving = 0;
            int takenMoney = 1;

            for(int currAge = 1; currAge <= age; currAge ++)
            {
                if(currAge % 2 == 0)
                {
                    totalSaving += ageMoney - takenMoney;
                    ageMoney += 10;
                }
                else
                {
                    toysCount++;
                }
            }
            totalSaving += toysCount * toyPrice;
            if (totalSaving >= priceOfLundry)
            {
                double moneyLeft = totalSaving - priceOfLundry;
                Console.WriteLine($"Yes! {moneyLeft:F2}");
            }
            else
            {
                double moneyNeed = priceOfLundry - totalSaving;
                Console.WriteLine($"No! {moneyNeed:F2}");
            }
        }
    }

}
