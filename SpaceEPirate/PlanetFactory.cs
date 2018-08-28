using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEPirate
{
    class PlanetFactory
    {
        public string planetName = "Prison Planet Gargantuon";
        public double xCoord = 75;
        public double yCoord = -75;
        
        public PlanetFactory(string iName, double iXCoord, double iYCoord)
        {
            planetName = iName;
            xCoord = iXCoord;
            yCoord = iYCoord;
        }

        internal static double DistanceToPlanet(PlanetFactory startPlanet, PlanetFactory endPlanet)
        {
            double distance = 0;
            distance = Math.Pow((startPlanet.xCoord - endPlanet.xCoord), 2) + Math.Pow((startPlanet.yCoord - endPlanet.yCoord), 2);
            distance = Math.Sqrt(distance);
            return distance;
        }
    }
}
