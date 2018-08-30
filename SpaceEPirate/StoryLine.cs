using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEPirate
{
    class StoryLine
    {
        internal static void Run()
        {
            string ship = "";
            string currentPlanet = "";

            Console.WriteLine("Welcome to Space Pirate!");

            UserProfile player = new UserProfile();

            currentPlanet = Planet.StartPlanet(0);
            StartPoint(player, currentPlanet);
            BeginAdventure(player, ship, currentPlanet);
        }

        static void StartPoint(UserProfile player, string currentPlanet)
        {
            Console.WriteLine($"The year was 3058, the year of the dog. You, {player.userName}, have been working with your grandfather for some time learning the family business, wtih the hope of " +
               $"one day taking over. Little did he know that his time was coming. Your grandfather was mysteriously killed while on a solo mission by " +
               $"the suspected jealous Space Bandit, Derricque! It is now up to you, {player.userName}, to continue your grandfather's life passion all while avenging his death! \n Good Luck!");
            Console.WriteLine("Press <Enter> to continue...");
            Console.ReadLine();
            Console.WriteLine("\n\n");
            Console.WriteLine("Instructions: You have been tasked to travel throughout the known territories to trade goods.  You can trade goods at the Market on each planet. " +
                    $"You can also purchase and repair your ship at Shipshape's Ship Shop.  Travel to each different planet to trade the goods and make a profit, or lose credits. " +
                    $"Make as much profit as you can, as that will be the only way to find out what happened to your grandfather! But beware, you have a limited time before you're caught by Derricque!  Good luck {player.userName}.");
            Console.WriteLine("Press <Enter> to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        static void BeginAdventure(UserProfile player, string ship, string currentPlanet)
        {
            int option = 0;
            int menuOptions = 3;

            //Create the types of Tradable Goods as objects
            TradeGood[] cargoInventory = new TradeGood[4];

            TradeGood tOil = new TradeGood("Oil", 5);
            TradeGood tSilver = new TradeGood("Silver", 10);
            TradeGood tGold = new TradeGood("Gold", 25);
            TradeGood tTitanium = new TradeGood("Titanium", 10);

            cargoInventory[0] = tOil;
            cargoInventory[1] = tSilver;
            cargoInventory[2] = tGold;
            cargoInventory[3] = tTitanium;

            //Create the planets as objects
            PlanetFactory earth = new PlanetFactory("Earth", 0, 0);
            PlanetFactory alphaCentari = new PlanetFactory("Alpha Centari", 0, -4.367);
            PlanetFactory m63 = new PlanetFactory("M63", -5, 4);
            PlanetFactory magrathea = new PlanetFactory("Magrathea", 50, 50);
            PlanetFactory vogosphere = new PlanetFactory("Vogosphere", -15, 10);
            PlanetFactory arrakis = new PlanetFactory("Arrakis", 7, 3);
            PlanetFactory corrin = new PlanetFactory("Corrin", -3, -9);
            PlanetFactory helionPrime = new PlanetFactory("Helion Prime", -5, -5);

            // Create space ships as objects
            SpaceShip[] shipShop = new SpaceShip[3];

            SpaceShip beginnerShip = new SpaceShip("Simple Simon", 000, 3000, 10, 4);
            SpaceShip MidLevelShip = new SpaceShip("Space Knight", 1500, 3500, 40, 7);
            SpaceShip ExpertShip = new SpaceShip("Avenger jet", 2500, 2000, 100, 9);

            shipShop[0] = beginnerShip;
            shipShop[1] = MidLevelShip;
            shipShop[2] = ExpertShip;



            Console.WriteLine($"Welcome to {currentPlanet}!  What would you like to do? \n1.The Trader's Market \n2.Shipshape Ship Shop\n3.Travel to next planet");

            option = Utility.ErrorHandler(menuOptions);

            Console.Clear();

            switch (option)
            {
                case 1:
                    Economy.MarketPlace(cargoInventory, player);  //Pass ShipObject, pass GoodObjects (via array or list possibly?)
                    Console.WriteLine("Something Happened");
                    Console.Read();
                    break;
                case 2:
                   SpaceShip.ShipGarage(shipShop, player);
                   
                    break;
                case 3:
                    Travel();
                    break;
                default:
                    break;
            }

        }




        internal static void Travel()
            {
                //Put code here
                Console.WriteLine("Nothing here yet");
            }
        
    }

}
