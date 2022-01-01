using System;

namespace _05.BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallPrice = double.Parse(Console.ReadLine());
            double cakePrice = 0.2 * hallPrice;
            double drinksPrice = cakePrice - 0.45 * cakePrice;
            double animatorPrice = hallPrice / 3;
            double needSum = hallPrice + cakePrice + drinksPrice + animatorPrice;
            Console.WriteLine(needSum);
        }
    }
}
