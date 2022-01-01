using System;

namespace _05.GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double countEd1 = 0;
            int countEd2 = 0;
            int countEd3 = 0;
            int countEd4 = 0;
            int countEd5 = 0;
            int countEd6 = 0;
            int invalid = 0;

            for (int i = 1; i <= n; i++)
            {
                double value = double.Parse(Console.ReadLine());

                if (value >= 0 && value <= 50)
                {
                    if (value < 10)
                    {
                        value *= 0.2;
                        countEd2++;
                    }

                    else if (value < 20)
                    {
                        value *= 0.3;
                        countEd3++;
                    }
                    else if (value < 30)
                    {
                        value *= 0.4;
                        countEd4++;
                    }
                    else if (value < 40)
                    {
                        value = 50.0;
                        countEd5++;
                    }
                    else
                    {
                        value = 100.0;
                        countEd6++;
                    }

                    countEd1 += value;
                }

                else
                {
                    countEd1 /= 2;
                    invalid++;
                }
                                 
                                     
                }
                       
            double totalCountEd2 = countEd2 * 1.0 / n * 100;
            double totalCountEd3 = countEd3 * 1.0 / n * 100;
            double totalCountEd4 = countEd4 * 1.0 / n * 100;
            double totalCountEd5 = countEd5 * 1.0 / n * 100;
            double totalCountEd6 = countEd6 * 1.0 / n * 100;
            double totalInvalid = invalid * 1.0 / n * 100;

            Console.WriteLine($"{countEd1:f2}");
            Console.WriteLine($"From 0 to 9: {totalCountEd2:f2}%");
            Console.WriteLine($"From 10 to 19: {totalCountEd3:f2}%");
            Console.WriteLine($"From 20 to 29: {totalCountEd4:f2}%");
            Console.WriteLine($"From 30 to 39: {totalCountEd5:f2}%");
            Console.WriteLine($"From 40 to 50: {totalCountEd6:f2}%");
            Console.WriteLine($"Invalid numbers: {totalInvalid:f2}%");
        }
    }
}
    
     
   

