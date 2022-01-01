using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowBows = int.Parse(Console.ReadLine());
            BigInteger snowBallValue = 0;
            BigInteger snowBallSnow = 0;
            BigInteger snowBallTimes = 0;
            int snowBallQuality = 0;
            BigInteger bestSnowBall = int.MinValue;
            string bestFormula = "";

            for (int i = 0; i < snowBows; i++)
            {
                snowBallSnow = BigInteger.Parse(Console.ReadLine());
                snowBallTimes = BigInteger.Parse(Console.ReadLine());
                snowBallQuality = int.Parse(Console.ReadLine());
                BigInteger value = snowBallSnow / snowBallTimes;
                snowBallValue = BigInteger.Pow(value, snowBallQuality);

                if(snowBallValue > bestSnowBall)
                {
                    bestSnowBall = snowBallValue;
                    bestFormula = $"{snowBallSnow} : {snowBallTimes} = {snowBallValue} ({snowBallQuality})";
                }
            }
            Console.WriteLine(bestFormula);
                
        }
    }
}
