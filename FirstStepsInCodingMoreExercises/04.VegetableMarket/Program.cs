using System;

namespace _04.VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVegetables = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());
            int kiloVegetables = int.Parse(Console.ReadLine());
            int kiloFruits = int.Parse(Console.ReadLine());
            
            double totalVegetables = priceVegetables * kiloVegetables;
            double totalFruits = priceFruits * kiloFruits;
            double sum = (totalVegetables + totalFruits) / 1.94 ;
            Console.WriteLine($"{(Math.Round(sum,2)):F2}");
        }
    }
}
