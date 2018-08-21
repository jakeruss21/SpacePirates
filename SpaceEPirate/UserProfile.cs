using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEPirate
{
    class UserProfile
    {

        internal static string UserName(string name = "")
        {
            int planet = 0;
            string namePlanet = "";
            Boolean answer = false;

            Console.Write("Please enter the character's name:  ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the number for your starting planet:");
            Console.WriteLine("1. Earth");
            Console.WriteLine("2. Alpha Centari");
            Console.WriteLine("3. M63");

            do
            { 
                try
                {
                    planet = int.Parse(Console.ReadLine());
                    answer = true;
                }
                catch (Exception)
                {
                    Console.Write("Please enter a valid planet ID number:  ");
                    answer = false;
                }

            }while (answer == false);

            namePlanet = Planet.DeterminePlanet(planet);
            Console.WriteLine($"Your character name is {name}.");
            Console.WriteLine($"You have {UserMoney()} credits");
            Console.WriteLine($"Your starting planet is: {namePlanet}");
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
