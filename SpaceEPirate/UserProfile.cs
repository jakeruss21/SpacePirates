using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEPirate
{
    class UserProfile
    {

        internal static string UserName(string name = "")
        {

            Console.Write("Please enter the character's name:  ");
            name = Console.ReadLine();
            Console.WriteLine($"Your character name is {name}.");
            Console.WriteLine($"You have {UserMoney()} credits");
            Console.WriteLine($"Your spaceship is a {SpaceShip.BeginnerShip()}");
            Console.ReadLine();
            return name;
        }

        internal static int UserMoney(int credits = 1000)
        {


            return credits;
        }
    }
}
