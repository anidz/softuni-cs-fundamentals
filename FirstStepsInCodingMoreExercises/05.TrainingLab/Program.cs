using System;

namespace _05.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());


            double WidthCm = h * 100;
            double HeightCm = w * 100;


            double deskRows = Math.Floor((WidthCm - 100) / 70); //-100 -> Коридор 

            double rows = Math.Floor(HeightCm / 120);

            double places = deskRows * rows - 3;

            Console.WriteLine(places);
        }
    }
}
