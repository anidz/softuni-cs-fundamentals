using System;

namespace _07.FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {

            double priceStrawberries = double.Parse(Console.ReadLine());
            double quantityBananas = double.Parse(Console.ReadLine());
            double quantityOranges = double.Parse(Console.ReadLine());
            double quantityRaspberries = double.Parse(Console.ReadLine());
            double quantityStrawberries = double.Parse(Console.ReadLine());

            double totalPricesStrawberries = priceStrawberries * quantityStrawberries;
            double priceRaspberries = priceStrawberries / 2;
            double totalPriceRaspberries = priceRaspberries * quantityRaspberries;
            double priceBananas = priceRaspberries - 0.8 * priceRaspberries;
            double totalPriceBananas = priceBananas * quantityBananas;
            double priceOranges = priceRaspberries - 0.4 * priceRaspberries;
            double totalPriceOranges = priceOranges * quantityOranges;
            double totalPrice = totalPricesStrawberries + totalPriceRaspberries + totalPriceBananas + totalPriceOranges;
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
