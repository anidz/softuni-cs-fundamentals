using System;
using System.Linq;
using System.Text;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            StringBuilder newPassword = new StringBuilder(password);
            string command = Console.ReadLine();
            while (command != "Complete")
            {
                string[] cmd = command.Split(" ");
                if (cmd.Contains("Upper"))
                {
                    var oldChar = newPassword[int.Parse(cmd[2])];
                    var newChar = char.ToUpper(oldChar);
                    newPassword.Remove(int.Parse(cmd[2]), oldChar.ToString().Length);
                    newPassword.Insert(int.Parse(cmd[2]), newChar);
                    Console.WriteLine(newPassword);
                }
                else if (cmd.Contains("Lower"))
                {
                    var oldChar = newPassword[int.Parse(cmd[2])];
                    var newChar = char.ToLower(oldChar);
                    newPassword.Remove(int.Parse(cmd[2]), oldChar.ToString().Length);
                    newPassword.Insert(int.Parse(cmd[2]), newChar);
                    Console.WriteLine(newPassword);
                }
                else if (cmd[0] == "Insert")
                {
                    int index = int.Parse(cmd[1]);
                    var newChar = cmd[2];
                    if (index >= 0 && index <= newPassword.Length - 1)
                    {
                        newPassword.Insert(index, newChar);
                        Console.WriteLine(newPassword);
                    }
                }
                else if (cmd[0] == "Replace")
                {
                    var currChar = char.Parse(cmd[1]);
                    var value = int.Parse(cmd[2]);
                    if (newPassword.ToString().Contains(currChar))
                    {
                        var oldValue = (int)currChar;
                        var newValue = oldValue + value;
                        var character = (char)newValue;
                        string newChar = character.ToString();
                        newPassword.Replace(currChar, character);
                        Console.WriteLine(newPassword);
                    }
                }
                else if (command == "Validation")
                {
                    bool result = newPassword.ToString().All(Char.IsLetter);
                    bool result1 = newPassword.ToString().All(Char.IsLetterOrDigit);
                    bool result2 = newPassword.ToString().All(c => Char.IsLetterOrDigit(c) || c == '_');
                    bool containsAtLeastOneUppercase = newPassword.ToString().Any(char.IsUpper);
                    bool containsAtLeastOneLowercase = newPassword.ToString().Any(char.IsLower);
                    bool containsInt = newPassword.ToString().Any(char.IsDigit);
                    if (newPassword.Length < 8)
                    {
                        Console.WriteLine("Password must be at least 8 characters long!");
                    }
                    if (!result && !result1 && !result2)
                    {
                        Console.WriteLine("Password must consist only of letters, digits and _!");
                    }
                    if (!containsAtLeastOneUppercase)
                    {
                        Console.WriteLine("Password must consist at least one uppercase letter!");
                    }
                    if (!containsAtLeastOneLowercase)
                    {
                        Console.WriteLine("Password must consist at least one lowercase letter!");
                    }
                    if (!containsInt)
                    {
                        Console.WriteLine("Password must consist at least one digit!");
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
    }

