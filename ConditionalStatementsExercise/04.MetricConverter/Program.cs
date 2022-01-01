using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double size = double.Parse(Console.ReadLine());
            String sourceMetric = Console.ReadLine();
            String destinationMetric = Console.ReadLine();

            if (sourceMetric == "mm")
            {
                size = size / 1000;
            }
               
            else if (sourceMetric == "cm")
            {
                size = size / 100;
            }
             
            
            else if (sourceMetric == "m")
            {
                size = size / 1;
            }
               
            if (destinationMetric == "m")
            {
                size = size * 1;
                Console.WriteLine($"{size:f3}");
            }
                
            else if (destinationMetric == "mm")
            {
                size = size * 1000;
                Console.WriteLine($"{size:f3}");
            }
                
            else if (destinationMetric == "cm")
            {
                size = size * 100;
                Console.WriteLine($"{size:f3}");
            }
           
              
          
           
           
        }
    }
    
    }

