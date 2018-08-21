using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEPirate
{
    class Planet
    {
        internal static string StartPlanet (int planetType = 0)
        {
            string planetName = "";
            Boolean answer = false;

            Console.WriteLine("Please enter the number for your starting planet:");
            Console.WriteLine("1. Earth");
            Console.WriteLine("2. Alpha Centari");
            Console.WriteLine("3. M63");

            do
            {
                try
                {
                    planetType = int.Parse(Console.ReadLine());
                    answer = true;
                }
                catch (Exception)
                {
                    Console.Write("Please enter a valid planet ID number:  ");
                    answer = false;
                }

            } while (answer == false);

            if (planetType == 1)
            {
                planetName = "Earth";
            }
            else if (planetType == 2)
            {
                planetName = "Alpha Centari";
            }
            else if(planetType == 3)
            {
                planetName = "M63";
            }
            else
            {
                planetName = "Earth";
            }
            return planetName;
        }


    }
}
