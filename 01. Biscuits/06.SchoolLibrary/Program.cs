using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SchoolLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> booksOnShelf = Console.ReadLine().Split("&").ToList();

            string splited = String.Empty;

            while (splited != "Done")
            {
                splited = Console.ReadLine();

                string[] action = splited.Split(" | ").ToArray();

                if (action[0] == "Add Book")
                {
                    string bookToAdd = action[1];

                    if (!booksOnShelf.Contains(bookToAdd))
                    {
                        booksOnShelf.Insert(0, bookToAdd);
                    }
                }
                else if (action[0] == "Take Book")
                {
                    string bookToRemove = action[1];

                    if (booksOnShelf.Contains(bookToRemove))
                    {
                        for (int i = 0; i < booksOnShelf.Count; i++)   
                        {
                            if (booksOnShelf[i] == bookToRemove)
                            {
                                booksOnShelf.RemoveAt(i);
                                break;
                            }
                        }
                    }
                }
                else if (action[0] == "Swap Books")
                {
                    string book1 = action[1];
                    string book2 = action[2];

                    int indexBook1 = 0;
                    int indexBook2 = 0;

                    if (booksOnShelf.Contains(book1) && booksOnShelf.Contains(book2))
                    {
                        for (int i = 0; i < booksOnShelf.Count; i++)
                        {
                            if (booksOnShelf[i] == book1)
                            {
                                indexBook1 = i;
                            }

                            if (booksOnShelf[i] == book2)
                            {
                                indexBook2 = i;
                            }
                        }
                        booksOnShelf.Insert(indexBook1, book2);
                        booksOnShelf.RemoveAt(indexBook1 + 1);

                        booksOnShelf.Insert(indexBook2, book1);
                        booksOnShelf.RemoveAt(indexBook2 + 1);
                    }
                }
                else if (action[0] == "Insert Book")
                {
                    string bookToInsert = action[1];

                    if (!booksOnShelf.Contains(bookToInsert))
                    {
                        booksOnShelf.Add(bookToInsert);
                    }
                }
                else if (action[0] == "Check Book")
                {
                    int givenIndex = int.Parse(action[1]);

                    if (givenIndex >= 0 && givenIndex <= booksOnShelf.Count - 1)
                    {
                        Console.WriteLine($"{booksOnShelf[givenIndex]}");
                    }
                }
            }
            Console.WriteLine(string.Join(", ", booksOnShelf));
        }
    }
}
        
    

