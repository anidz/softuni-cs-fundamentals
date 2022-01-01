using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, List<Dragon>> fillDragons = new Dictionary<string, List<Dragon>>();
            for (int i = 0; i < count; i++)
            {
                string[] dragons = Console.ReadLine().Split();
                _ = dragons[2] == "null" ? dragons[2] = "45" : dragons[2] = dragons[2];
                _ = dragons[3] == "null" ? dragons[3] = "250" : dragons[3] = dragons[3];
                _ = dragons[4] == "null" ? dragons[4] = "10" : dragons[4] = dragons[4];
                Dragon dragon = new Dragon(dragons[1], double.Parse(dragons[2]), double.Parse(dragons[3]),
                    double.Parse(dragons[4]));

                if (!fillDragons.ContainsKey(dragons[0]))
                {
                    fillDragons.Add(dragons[0], new List<Dragon>() { dragon });

                }

                bool isValid = true;
                if (fillDragons[dragons[0]].Any(x => x.Name == dragon.Name))
                {

                    isValid = false;
                    fillDragons[dragons[0]].RemoveAll(x => x.Name == dragon.Name);
                    fillDragons[dragons[0]].Add(dragon);
                }
                if (isValid)
                {
                    fillDragons[dragons[0]].Add(dragon);
                }
            }
            foreach (var VARIABLE in fillDragons)
            {
                Console.WriteLine($"{VARIABLE.Key}::({VARIABLE.Value.Select(x => x.Damage).Average():f2}/{VARIABLE.Value.Select(x => x.Health).Average():f2}/{VARIABLE.Value.Select(x => x.Armor).Average():f2})");
                foreach (var VARIABLE1 in VARIABLE.Value.OrderBy(x => x.Name))
                {
                    Console.WriteLine(VARIABLE1);
                }
            }
        }
    }
    public class Dragon
    {
        public Dragon(string name, double damage, double health, double armor)
        {
            Name = name;

            Damage = damage;
            Health = health;
            Armor = armor;
        }
        public string Name { get; set; }

        public double Damage { get; set; }
        public double Health { get; set; }
        public double Armor { get; set; }

        public override string ToString() => $"-{Name} -> damage: {Damage}, health: {Health}, armor: {Armor}";
    }
}
 
        
    

