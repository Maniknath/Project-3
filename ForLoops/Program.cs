﻿using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int tUnits, gUnits, solution, total;
            char doAgain;
            bool decition = true;

            while (decition == true)
            {
                solution = 1;
                Console.WriteLine("Please enter the total number of units (the 'n' in nPr)");
                tUnits = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Please enter the grouping of untits from the total (the 'r' in nPr)");
                gUnits = Convert.ToInt16(Console.ReadLine());

                total = tUnits - gUnits;

                for (int temp = tUnits; temp > total; temp--)
                {
                    solution *= temp;
                }

                Console.WriteLine("The solution to you permutation is: " + solution + ".");
                Console.ReadLine();
                Console.WriteLine("Would you like to run this program agai? (Y or N)");
                doAgain = Convert.ToChar(Console.ReadLine());

                if (doAgain != 'y' && doAgain != 'Y')
                {
                    decition = false;
                }
            }

        }

    }



}
