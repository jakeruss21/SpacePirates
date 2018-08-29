using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEPirate
{
    class SpaceShip
    {
        string shipName = "";
        int shipCost = 0;
        int cargoCapacity = 0;
        


        public SpaceShip(string ishipName, int ishipCost, int icargoCapacity, int ifuelCapacity )
        {
            shipName = ishipName;
            shipCost = ishipCost;
            cargoCapacity = icargoCapacity;
            fuelCapacity = ifuelCapacity;
        }

        
       internal static int ShipGarage(int shipType = 0)
       {
            int numOptions = 3;

            Console.WriteLine("Welcome to the ship garage. You may select or buy a ship you would like to fly");
            Console.ReadLine();

            Console.WriteLine($"Please enter the number for the good you buy or fly");
            Console.WriteLine($"=========================================================================");
            Console.WriteLine($"Item                 || Cost of Ship  || Amount of Cargo space avalible ");
            Console.WriteLine($"=========================================================================");
            Console.WriteLine($"1. {ConvertShips(1)}      || {ShipCost(1)}CC           ||  {CargoCapacity(1)}      ");
            Console.WriteLine($"2. {ConvertShips(2)}      || {ShipCost(2)}CC        ||  {CargoCapacity(2)}       ");
            Console.WriteLine($"3. {ConvertShips(3)}       || {ShipCost(3)}CC        ||  {CargoCapacity(3)}       ");

            shipType = Utility.ErrorHandler(numOptions);

            return shipType;
        }
        internal static string ConvertShips(int shipType = 0)
        {
            
        }

        
        
        }
       
    }
}
