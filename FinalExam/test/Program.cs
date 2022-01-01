using System;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string spell = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Abracadabra")
            {
                StringBuilder text = new StringBuilder();
                string[] info = command.Split();
                string act = info[0];
                if (act == "Abjuration")
                {
                    spell = spell.ToUpperInvariant();
                    Console.WriteLine(spell);
                }
                else if (act == "Necromancy")
                {
                    spell = spell.ToLowerInvariant();
                    Console.WriteLine(spell);
                }
                else if (act == "Illusion")
                {
                    int index = int.Parse(info[1]);
                    char letter = char.Parse(info[2]);
                    if (index <= spell.Length - 1 && index >= 0)
                    {
                        char[] change = spell.ToCharArray();
                        change[index] = letter;
                        spell = string.Join("", change);
                        Console.WriteLine("Done!");
                    }
                    else
                    {
                        Console.WriteLine("The spell was too weak.");
                    }
                }
                else if (act == "Divination")
                {
                    string oldString = info[1];
                    string newString = info[2];
                    if (spell.Contains(oldString))
                    {
                        spell = spell.Replace(oldString, newString);
                        Console.WriteLine(spell);
                    }
                }
                else if (act == "Alteration")
                {
                    string name = info[1];
                    if (spell.Contains(name))
                    {
                        string empty = string.Empty;
                        spell = spell.Replace(name, empty);
                        Console.WriteLine(spell);
                    }
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }
                command = Console.ReadLine();
            }
        }
    }
}

    }
}
