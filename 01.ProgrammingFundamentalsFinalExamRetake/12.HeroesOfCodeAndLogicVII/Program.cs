using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDic = new Dictionary<string, List<int>>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                var currInput = input.Split().ToList(); 

                string heroName = currInput[0];
                int hP = int.Parse(currInput[1]);
                int mP = int.Parse(currInput[2]);

                myDic.Add(heroName, new List<int>() { hP, mP, 0 });


            }
            string comands;
            while ((comands = Console.ReadLine()) != "End")
            {
                var currCommands = comands.Split(" - ").ToList();

                string singleComand = currCommands[0];
                string currHero = currCommands[1];

                if (singleComand == "CastSpell")   

                {
                    int mPNeeded = int.Parse(currCommands[2]);
                    string spellName = currCommands[3];
                    int currmP = myDic[currHero][1];

                    if (mPNeeded > currmP)
                    {
                        Console.WriteLine($"{currHero} does not have enough MP to cast {spellName}!");


                    }
                    else
                    {
                        Console.WriteLine($"{currHero} has successfully cast {spellName} and now has {currmP - mPNeeded} MP!");

                        myDic[currHero][1] = currmP - mPNeeded;
                    }

                }
                else if (singleComand == "TakeDamage")   

                {
                    int damage = int.Parse(currCommands[2]);
                    string attacker = currCommands[3];
                    int currHp = myDic[currHero][0];

                    int redused = currHp - damage;
                    myDic[currHero][0] = redused;

                    if (redused <= 0)
                    {
                        Console.WriteLine($"{currHero} has been killed by {attacker}!");

                        myDic.Remove(currHero);

                    }
                    else
                    {
                        Console.WriteLine($"{currHero} was hit for {damage} HP by {attacker} and now has {redused} HP left!");
                    }


                }
                else if (singleComand == "Recharge")   

                {
                    int amount = int.Parse(currCommands[2]);
                    int curMp = myDic[currHero][1];
                    int lifted = curMp + amount;

                    if (lifted > 200)
                    {

                        lifted = 200;
                        Console.WriteLine($"{currHero} recharged for {200 - curMp} MP!");
                        myDic[currHero][1] = 200;
                    }
                    else
                    {
                        Console.WriteLine($"{currHero} recharged for {lifted - curMp} MP!");
                        myDic[currHero][1] = lifted;
                    }


                }
                else if (singleComand == "Heal")  

                {
                    int amount = int.Parse(currCommands[2]);
                    int curHp = myDic[currHero][0];
                    int lifted = curHp + amount;

                    if (lifted > 100)
                    {

                        lifted = 100;
                        Console.WriteLine($"{currHero} healed for {100 - curHp} HP!");

                        myDic[currHero][0] = 100;
                    }
                    else
                    {

                        Console.WriteLine($"{currHero} healed for {lifted - curHp} HP!");
                        myDic[currHero][0] = lifted;
                    }

                }
            }

            foreach (var kvp in myDic.OrderByDescending(x => x.Value[0]).ThenBy(y => y.Key))
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine($"  HP: {kvp.Value[0]}");
                Console.WriteLine($"  MP: {kvp.Value[1]}");
            }
        }
    }
}
    

