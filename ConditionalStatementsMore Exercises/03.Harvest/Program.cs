using System;

namespace _03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int vineyard = int.Parse(Console.ReadLine());
            double grapesSqM = double.Parse(Console.ReadLine());
            int neededLitersOfWine = int.Parse(Console.ReadLine());
            int numbersOfWorkers = int.Parse(Console.ReadLine());

            double totalGrapes = vineyard * grapesSqM;
            double wine = 0.4 * totalGrapes / 2.5;

            if (wine >= neededLitersOfWine)
            {
                double remainingWine = wine - neededLitersOfWine;
                double winePerWorker = Math.Ceiling(remainingWine / numbersOfWorkers);
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(remainingWine)} liters left -> {winePerWorker} liters per person.");

            }
            else
            {
                double remainingWine = Math.Floor(neededLitersOfWine - wine);
                Console.WriteLine($"It will be a tough winter! More {remainingWine} liters wine needed.");
            }
        }
    }
}
