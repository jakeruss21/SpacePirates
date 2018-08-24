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
            Console.WriteLine("Press <Enter> to continue...");
            Console.ReadLine();
            Console.WriteLine("\n\n");
            Console.WriteLine("Instructions: You have been tasked to travel throughout the known territories to trade goods.  You can trade goods at the Market on each planet. " +
                    $"You can also purchase and repair your ship at Shipshape's Ship Shop.  Travel to each different planet to trade the goods and make a profit, or lose credits. " +
                    $"Make as much profit as you can, as that will be the only way to find out what happened to your grandfather! But beware, you have a limited time before you're caught by Derricque!  Good luck {characterName}.");
            Console.WriteLine("Press <Enter> to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        static void BeginAdventure(string characterName, int credits, string ship, string currentPlanet)
        {
            //double year = 0;
            int option = 0;
            bool answer = false;  //used to check inputs
            int cargo = 1000;  // Place holder
            int[] latestGoods = new int[4];

            Console.WriteLine($"Welcome to {currentPlanet}!  What would you like to do? \n1.The Trader's Market \n2.Shipshape Ship Shop\n3.Travel to next planet");
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

                if (option < 1 || option > 3)
                {
                    Console.Write("Please enter a valid option:  ");
                }
                else { }
            }

            switch (option)
            {
                case 1:
                    latestGoods = MarketPlace(cargo, credits);
                    Console.WriteLine("Something Happened");
                    Console.Read();
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

            switch(latestGoods[0])
            {
                // Add the right goods to the right place... hopefully
                default:
                    break;
            }

        }

        internal static int[] MarketPlace(int storage = 1000, int credits = 0)
        {
            int[] newGoods = new int[4]; // 0 = goodType; 1 = Quantity of goodType; 2 = remaining credits after purchase; 3 = remaining cargo space;

            int option = 0;
            Boolean answer = false;

            Console.WriteLine($"You have {credits}CC and {storage} space available in your ship.\n");
            Console.WriteLine($"What would you like to do? \n1. Buy \n2. Sell \n3. Go to Planet Menu");

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

                if (option < 1 || option > 3)
                {
                    Console.Write("Please enter a valid option:  ");
                }
                else { }
            }

            switch (option)
            {
                case 1:
                    newGoods = BuyGoods(storage, credits);
                    break;
                case 2:
                    newGoods = SellGoods(storage, credits);
                    break;
                default:
                    break;
            }

            return newGoods;
        }

        internal static int[] BuyGoods(int storage = 1000, int credits = 0)
        {
            int[] newGoods = new int[4];
            string nameGood = "";
            int cost = 0;
            int cargoSpace = 0;

            newGoods[0] = Economy.BuyGoods();  //Type of good purchased
            nameGood = Economy.ConvertNumberGoods(newGoods[0]);

            newGoods[1] = Economy.TotalCost(newGoods[0], credits, storage); //Quantity of goods purchased

            cost = newGoods[1] * Economy.UnitCost(newGoods[0]);  //Remaining CosmicCredits
            newGoods[2] = credits - cost;

            cargoSpace = newGoods[1] * Economy.UnitSize(newGoods[0]);
            newGoods[3] = storage - cargoSpace;  //Remaining storage space in the ship

            Console.WriteLine($"You have purchased: {newGoods[1]} units of {nameGood} for {cost}CC.");
            Console.WriteLine($"You have {newGoods[2]}CC and {newGoods[3]} storage space on your ship remaining.");
            Console.ReadLine();
            Console.Clear();

            return newGoods;
        }

        internal static int[] SellGoods(int storage = 1000, int credits = 0)
        {
            int[] soldGoods = new int[4];
            Console.WriteLine("Do something here");
            Console.Read();
            return soldGoods;
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
            Console.WriteLine($"=========================================================================");
            Console.WriteLine($"1. {ConvertShips(1)}      || {ShipCost(1)}CC           ||  {CargoCapacity(1)}      ");
            Console.WriteLine($"2. {ConvertShips(2)}      || {ShipCost(2)}CC        ||  {CargoCapacity(2)}       ");
            Console.WriteLine($"3. {ConvertShips(3)}       || {ShipCost(3)}CC        ||  {CargoCapacity(3)}       ");

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
        internal static int CargoCapacity(int shipType = 0)
        {
            int capacity = 0;

            switch (shipType)
            {
                case 1:
                    capacity = 3000;
                    break;
                case 2:
                    capacity = 3500;
                    break;
                case 3:
                    capacity = 2000;
                    break;
                default:
                    break;
            }
            return capacity;
        }

        internal static void Travel()
            {
                //Put code here
                Console.WriteLine("Nothing here yet");
            }
        
    }

}
