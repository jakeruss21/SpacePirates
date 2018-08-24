using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEPirate
{
    class SpaceShip
    {

        internal static string BeginnerShip(string bShip = "SimpleSimon")
        {
            return bShip;
        }
        internal static string MidLevelShip(string mShip = "Space Knight")
        {

            return mShip;
        }
        internal static string ExpertShip(string topShip = "Avenger jet")
        {

            return topShip;
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

    }
}
