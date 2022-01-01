using System;

namespace _03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositAmount = double.Parse(Console.ReadLine());
            double termOfTheDepositInMonths = double.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());

            double accruedInterest = depositAmount * annualInterestRate / 100;
            double interestForMonth = accruedInterest / 12;
            double amountAtTheEndOfTheTerm = depositAmount + (termOfTheDepositInMonths) * interestForMonth;
            Console.WriteLine(amountAtTheEndOfTheTerm);
        }
    }
}
