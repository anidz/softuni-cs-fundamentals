using System;

namespace _05.PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string password = "s3cr3t!P@ssw0rd";
            if (word == password) 
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
