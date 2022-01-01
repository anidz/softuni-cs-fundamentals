using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int numberOfSweet = int.Parse(Console.ReadLine());
            int numberOfCake = int.Parse(Console.ReadLine());
            int numberOfWaffles = int.Parse(Console.ReadLine());
            int numberOfPancakes = int.Parse(Console.ReadLine());
                                 
            double moneyPerDay = ((numberOfCake * 45) + (numberOfWaffles * 5.80) + (numberOfPancakes * 3.20)) * numberOfSweet;
            double totalMoney = moneyPerDay * numberOfDays;
            double clearMoney = totalMoney - totalMoney / 8;
            Console.WriteLine(clearMoney);

        }
    }
 }

