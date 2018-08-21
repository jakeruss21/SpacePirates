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
            Console.WriteLine($"The year was 3058, the year of the dog. You, {characterName}, have been working with your grandfather for some time learning the family business, wtih the hope of " +
               $"one day taking over. Little did he know that his time was coming. Your grandfather was mysteriously killed while on a solo mission by " +
               $"the suspected jealous Space Bandit, Derricque! It is now up to you, {characterName}, to continue your grandfather's life passion all while avenging his death! \n Good Luck!");
            Console.ReadLine();
        }
        
    }

}
