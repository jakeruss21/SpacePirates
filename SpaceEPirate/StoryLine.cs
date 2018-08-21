using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEPirate
{
    class StoryLine
    {
        internal static void Run()
        {
            string character = "";
            int credits = 0;
            string ship = "";
            string planet = "";

            Console.WriteLine("Welcome to Space Pirate!");
            character = UserProfile.UserName();
            credits = UserProfile.UserMoney();
            ship = SpaceShip.BeginnerShip();
        }




    }

}
