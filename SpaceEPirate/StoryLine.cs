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
            BeginAdventure(characterName, credits, ship, currentPlanet);
        }

        static void StartPoint(string characterName, int credits, string ship, string currentPlanet)
        {
            Console.WriteLine($"The year was 3058, the year of the dog. You, {characterName}, have been working with your grandfather for some time learning the family business, wtih the hope of " +
               $"one day taking over. Little did he know that his time was coming. Your grandfather was mysteriously killed while on a solo mission by " +
               $"the suspected jealous Space Bandit, Derricque! It is now up to you, {characterName}, to continue your grandfather's life passion all while avenging his death! \n Good Luck!");
            Console.ReadLine();
            Console.WriteLine("\n\n");
            Console.WriteLine("Instructions: You have been tasked to travel throughout the known territories to trade goods.  You can trade goods at the Market on each planet. " +
                    $"You can also purchase and repair your ship at Shipshape's Ship Shop.  Travel to each different planet to trade the goods and make a profit, or lose credits. " +
                    $"Make as much profit as you can, as that will be the only way to find out what happened to your grandfather! But beware, you have a limited time before you're caught by Derricque!  Good luck {characterName}.");

            Console.ReadLine();
            Console.Clear();
        }

        static void BeginAdventure(string characterName, int credits, string ship, string currentPlanet)
        {
            //double year = 0;
            int option = 0;
            bool answer = false;  //used to check inputs
            int cargo = 0;

            Console.WriteLine($"Welcome to {currentPlanet}!  Where would you like to do? \n1.The Trader's Market\n2.Shipshape Ship Shop\n3.Travel to next planet");
            while (option < 1 || option > 3)
            {
                do
                {
                    try
                    {
                        option = int.Parse(Console.ReadLine());
                        answer = true;
                    }
                    catch (Exception)
                    {
                        Console.Write("Please enter a valid option:  ");
                        answer = false;
                    }
                } while (answer == false);

                if (option < 1 || option > 4)
                {
                    Console.Write("Please enter a valid option:  ");
                }
                else { }
            }

            switch (option)
            {
                case 1:
                    MarketPlace(cargo, credits);
                    break;
                case 2:
                    ShipGarage();
                    break;
                case 3:
                    Travel();
                    break;
                default:
                    break;
            }

        }

        internal static int[] MarketPlace(int storage = 0, int credits = 0, int cargoSpace = 1000)
        {
            int[] newGoods = new int[2];
            string nameGood = "";

            newGoods[0] = Economy.BuyGoods();
            nameGood = Economy.ConvertNumberGoods(newGoods[0]);

            newGoods[1] = Economy.TotalCost(newGoods[0], credits, cargoSpace);

            Console.WriteLine($"You have purchased: {newGoods[1]} units of {nameGood}.");
            Console.ReadLine();
            Console.Clear();

            return newGoods;
        }

        internal static int ShipGarage(int shipType = 0)
        {
            Boolean answer = false;

            //Put code here
            Console.WriteLine("Welcome to the ship garage. You may select or buy a ship you would like to fly");
            Console.ReadLine();

            Console.WriteLine($"Please enter the number for the good you buy or fly");
            Console.WriteLine($"=========================================================================");
            Console.WriteLine($"Item                 || Cost of Ship  || Amount of Cargo space avalible ");
            Console.WriteLine($"1. {ConvertShips(1)}            || {ShipCost(1)}CC            || 2 ");
            Console.WriteLine($"2. {ConvertShips(2)}               || {ShipCost(2)}CC            || 1 ");
            Console.WriteLine($"3. {ConvertShips(3)}              || {ShipCost(3)}CC            || 5 ");

            while (shipType < 1 || shipType > 3)
            {
                do
                {
                    try
                    {
                        shipType = int.Parse(Console.ReadLine());
                        answer = true;
                    }
                    catch (Exception)
                    {
                        Console.Write("Please enter a valid good ID number:  ");
                        answer = false;
                    }
                } while (answer == false);

                if (shipType < 1 || shipType > 3)
                {
                    Console.Write("Please enter a valid good ID number:  ");
                }
                else { }
            }
            return shipType;
        }
        internal static string ConvertShips(int shipType = 0)
        {
            string shipName = "";
            switch (shipType)
            {
                case 1:
                    shipName = "Simple Simon";
                    break;
                case 2:
                    shipName = "Space Knight";
                    break;
                case 3:
                    shipName = "Avenger Jet";
                    break;
                default:
                    break;
            }
            return shipName;
        }

        internal static int ShipCost(int shipType = 0)
        {
            int cost = 0;

            switch (shipType)
            {
                case 1:
                    cost = 000;
                    break;
                case 2:
                    cost = 1500;
                    break;
                case 3:
                    cost = 2500;
                    break;
                default:
                    break;
            }
            return cost;

        }

        internal static void Travel()
        {
            //Put code here
            Console.WriteLine("Nothing here yet");
        }

    }

}
