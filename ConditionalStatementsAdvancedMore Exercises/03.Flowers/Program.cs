using System;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            double priceCh = 0;
            double priceRo = 0;
            double priceTu = 0;
            

            if(season == "Spring" || season == "Summer")
            {
                priceCh = 2 * chrysanthemums;
                priceRo = 4.1 * roses;
                priceTu = 2.5 * tulips;
            }
            else if(season == "Autumn" || season == "Winter")
            {
                priceCh = 3.75 * chrysanthemums;
                priceRo = 4.5 * roses;
                priceTu = 4.15 * tulips;
            }
            double totalPrice = priceCh + priceRo + priceTu;
            if(tulips > 7 && season == "Spring")
            {
                totalPrice *= 0.95;

            }
            else if(roses >= 10 && season == "Winter")
            {
                totalPrice *= 0.9;
            }
            if(holiday == "Y")
            {
                totalPrice *= 1.15;

            }
            if(chrysanthemums + roses + tulips >= 20 )
            {
                totalPrice *= 0.8;
            }
            Console.WriteLine($"{(totalPrice + 2):f2}");
        }
    }
}
