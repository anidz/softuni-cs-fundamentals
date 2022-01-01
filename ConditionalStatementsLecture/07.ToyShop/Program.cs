using System;

namespace _07.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double priceForPuzzel = 2.60;
            const double priceForDoll = 3;
            const double priceForBear = 4.10;
            const double priceForMinion = 8.20;
            const double priceForTruck = 2;

            double priceForVacantion = double.Parse(Console.ReadLine());
            double countOfPuzzels = double.Parse(Console.ReadLine());
            double countOfDolls = double.Parse(Console.ReadLine());
            double countOfBears = double.Parse(Console.ReadLine());
            double countOfMinions = double.Parse(Console.ReadLine());
            double countOfTrucks = double.Parse(Console.ReadLine());

            double countOfToys = countOfPuzzels + countOfDolls + countOfBears + countOfMinions + countOfTrucks;
            double priceOfAllToys = (countOfPuzzels * priceForPuzzel) + (countOfDolls * priceForDoll) + (countOfBears * priceForBear) + (countOfMinions * priceForMinion) + (countOfTrucks * priceForTruck);

            if (countOfToys >= 50)
            {
                priceOfAllToys = priceOfAllToys - (priceOfAllToys * 0.25);
            }
            priceOfAllToys = priceOfAllToys - (priceOfAllToys * 0.1);
                                   
            if(priceOfAllToys >= priceForVacantion)
            {
                double enoughMoney = priceOfAllToys - priceForVacantion;
                Console.WriteLine($"Yes! {(enoughMoney):f2} lv left."); 
            }
            else 
            {
                double neededMoney = priceForVacantion - priceOfAllToys;
                Console.WriteLine($"Not enough money! {(neededMoney):f2} lv needed.");
                
            }



        }
    }
}
