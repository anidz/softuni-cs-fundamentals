using System;

namespace _06.RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int Formula = size - 1;

            for (int row = 1; row <= size; row++)
            {
                for (int EmptyPlace = 0; EmptyPlace < Formula; EmptyPlace++)
                {
                    Console.Write(' ');
                }

                Console.Write('*');
                for (int coll = 0; coll < row - 1; coll++)
                {
                    Console.Write(" *");
                }
                Formula--;
                Console.WriteLine();
            }

            Formula = 1;
            int formulaStars = size - 1;
            int stars = formulaStars;

            for (int row = 0; row < formulaStars; row++)
            {
                for (int coll = 0; coll < Formula; coll++)
                {
                    Console.Write(' ');
                }

                Console.Write('*');

                for (int cool = 0; cool < stars - 1; cool++)
                {
                    Console.Write(" *");
                }
                --stars;
                Formula++;
               
                Console.WriteLine();
            }
        }
        }
    }

