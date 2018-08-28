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
            int numOptions = 8;

            Console.WriteLine("Please enter the number for your starting planet:");
            Console.WriteLine("1. Earth");
            Console.WriteLine("2. Alpha Centari");
            Console.WriteLine("3. M63");

            planetType = Utility.ErrorHandler(numOptions);
            

            switch (planetType)
            {
                case 1:
                    planetName = "Earth";
                    break;
                case 2:
                    planetName = "Alpha Centari";
                    break;
                case 3:
                    planetName = "M63";
                    break;
                default:
                    planetName = "Prison Planet Gargantuon";
                    break;
            }

            Console.WriteLine($"You have chosen to begin on Planet {planetName}.");
            Console.ReadLine();
            Console.Clear();
            return planetName;
        }

        internal static double CalcDistance(int startPlanet, int endPlanet)
        {
            double distance = 0;
            double startX = 0;
            double startY = 0;
            double endX = 0;
            double endY = 0;

            switch(startPlanet)
            {
                case 1:
                    startX = 0;
                    startY = 0;
                    break;
                case 2:
                    startX = 0;
                    startY = -4.367;
                    break;
                case 3:
                    startX = -5;
                    startY = 4;
                    break;
                default:
                    break;
            }

            switch(endPlanet)
            {
                case 1:
                    endX = 0;
                    endY = 0;
                    break;
                case 2:
                    endX = 0;
                    startY = -4.367;
                    break;
                case 3:
                    endX = -5;
                    endY = 4;
                    break;
                default:
                    break;
            }

            distance = Math.Pow((startX - endX), 2) + Math.Pow((startY - endY), 2);
            distance = Math.Sqrt(distance);
            return distance;                
        }

        internal static void Earth()
        {
            //TODO -- What does this do?
        }

        internal static void AlphaCentari ()
        {
            //TODO -- What does this do?
        }

        internal static void M63()
        {
            //TODO -- What does this do?
        }
    }
}
