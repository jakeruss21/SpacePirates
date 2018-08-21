using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEPirate
{
    class StoryLine
    {
        internal static void Run()
        {
            string characterName = "";
            int credits = 0;
            string ship = "";
            string currentPlanet = "";

            Console.WriteLine("Welcome to Space Pirate!");
            characterName = UserProfile.UserName("");
            credits = UserProfile.UserMoney(1000);
            ship = SpaceShip.BeginnerShip("SimpleSimon");
            currentPlanet = Planet.StartPlanet(0);
        }



    }

}
