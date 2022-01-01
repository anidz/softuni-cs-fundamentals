using System;

namespace _09.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMetersLandsCaped = double.Parse(Console.ReadLine());
            double priceOneSquareMeters = squareMetersLandsCaped * 7.61;
            double discountSquareMetersLandsCaped = 0.18 * priceOneSquareMeters;
            double finalResult = priceOneSquareMeters - discountSquareMetersLandsCaped;
            Console.WriteLine($"The final price is: {finalResult} lv.");
            Console.WriteLine($"The discount is: {discountSquareMetersLandsCaped} lv.");
            
        }
    }
}
