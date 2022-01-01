using System;

namespace _10.WeatherForecastPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            double gradusi = double.Parse(Console.ReadLine());
            if (gradusi >= 26.00)
            {
                if (gradusi < 35.00)
                    Console.WriteLine("Hot");
            }
            if (gradusi >= 20.1)
            {
                if (gradusi <= 25.9)
                    Console.WriteLine("Warm");
            }
            if (gradusi >= 15.00)
            {
                if (gradusi <= 20.00)
                    Console.WriteLine("Mild");
            }
            if (gradusi >= 12.00)
            {
                if (gradusi <= 14.9)
                    Console.WriteLine("Cool");
            }
            {
                if (gradusi >= 5.00)
             
            {
                if (gradusi <= 11.9)
                    Console.WriteLine("Cold");
            }
                else if (gradusi <= 5)
                {
                    Console.WriteLine("unknown");
                }
                if(gradusi > 35)
                {
                    Console.WriteLine("unknown");
                }
                
                }
            }
        }
    }

