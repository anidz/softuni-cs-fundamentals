using System;

namespace _06.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceMackerel = double.Parse(Console.ReadLine());
            double priceToy = double.Parse(Console.ReadLine());
            double quantityBonito = double.Parse(Console.ReadLine());
            double quantityHorseMackerel = double.Parse(Console.ReadLine());
            double quantityMussels = double.Parse(Console.ReadLine());
            double priceBonito = priceMackerel + priceMackerel * 0.60;
            double totalPriceBonito = quantityBonito * priceBonito;
            double priceHorseMackerel = priceToy + priceToy * 0.80;
            double totalPriceHorseMackerel = quantityHorseMackerel * priceHorseMackerel;
            double priceMussels = quantityMussels * 7.5;
            double totalPrice = totalPriceBonito + totalPriceHorseMackerel + priceMussels;
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
