using System;

namespace _08.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfDogs = int.Parse(Console.ReadLine());
            int countOfOtherAnimals = int.Parse(Console.ReadLine());
            double foodForDogPrice = countOfDogs * 2.5;
            double foodForOtherAnimalsPrice = countOfOtherAnimals * 4;
            double finalResult = foodForDogPrice + foodForOtherAnimalsPrice;
            Console.WriteLine($"{finalResult} lv.");


        }
    }
}
