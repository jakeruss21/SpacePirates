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
            StartPoint(characterName, credits, ship, currentPlanet);
        }

        static void StartPoint(string characterName, int credits, string ship, string currentPlanet)
        {
            Console.WriteLine($"The year was 3058, the year of the dog. {characterName} had been working with their grandfathers for some time learning the family business, wtih the hope of" +
               $" one day taking over.Little did he know that his time was coming. {characterName}'s grandfather was mysteriously killed while on a solo mission by " +
                $"the suspected jelous Space Bandit! It is now up to {characterName} to continue grandfather's life passion all while avenging grandfathers death");
            Console.ReadLine();
        }
        
    }

}
