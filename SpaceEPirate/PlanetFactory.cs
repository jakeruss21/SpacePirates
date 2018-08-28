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

    }
}
