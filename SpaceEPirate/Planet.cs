using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEPirate
{
    class Planet
    {
        internal static string DeterminePlanet (int planetType = 0)
        {
            string planetName = "";

            if(planetType == 1)
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
