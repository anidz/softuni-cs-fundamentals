using System;

namespace _07.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolias = int.Parse(Console.ReadLine());
            int hyacinths = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cacti = int.Parse(Console.ReadLine());
            double priceGift = double.Parse(Console.ReadLine());

            double priceMagnolias = 3.25;
            double priceHyacinths = 4.0;
            double priceRoses = 3.50;
            double priceCacti = 8.0;
            double sum = magnolias * priceMagnolias + hyacinths * priceHyacinths + roses * priceRoses + cacti * priceCacti;
            double profit = sum - 0.05 * sum;
            
            if(profit >= priceGift)
            {
                double d = profit - priceGift;
                Console.WriteLine($"She is left with {Math.Floor(d)} leva.");
            }
            else
            {
                double d = priceGift - profit;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(d)} leva.");
            }
        }
    }
}
