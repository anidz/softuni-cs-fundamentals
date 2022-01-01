using System;

namespace _10.MultiplyBy2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double sum = 0;
           
            for (int i = 0; i >= number; i++)
            {


                if (number <= 0)
                {
                    number++;
                    Console.WriteLine("Negative number!");
                    break;

                }
                else if(number >= 0)
                {
                    number++;
                 
                }
               
            }
            sum = number * 2;
            Console.WriteLine($"Result: {sum:f2}");

        }
    }
}

        

    
            
            
        
    


