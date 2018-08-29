using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEPirate
{
    class SpaceShip
    {
        public string shipName = "";
        public int shipCost = 0;
        public int cargoCapacity = 0;
        public double fuelCapacity = 0;
        public int topSpeed = 0;
        


        public SpaceShip(string ishipName, int ishipCost, int icargoCapacity, double ifuelCapacity, int iTopSpeed)
        {
            shipName = ishipName;
            shipCost = ishipCost;
            cargoCapacity = icargoCapacity;
            fuelCapacity = ifuelCapacity;
            topSpeed = iTopSpeed;
        }

        
       internal static int[] ShipGarage(SpaceShip[] shipShop, int credits)
       {
            int numOptions = 3;
            
            {
                int[] newShips= new int[3]; // 0 = goodType; 1 = Quantity of goodType; 2 = remaining credits after purchase; 3 = remaining cargo space;
                int option = 0;

               
               

             

               Console.WriteLine("Welcome to the ship garage. You may select or buy a ship you would like to fly." +
                "You currently have {credits}cc.");
            Console.ReadLine();

            Console.WriteLine($"Please enter the number for the good you buy or fly");
            Console.WriteLine($"=========================================================================");
            Console.WriteLine($"Item                 || Cost of Ship  || Amount of Cargo space avalible ");
            Console.WriteLine($"=========================================================================");
            Console.WriteLine($"1.      || {ShipCost(1)}CC           ||  {cargoCapacity(1)}      ");
            Console.WriteLine($"2. {ConvertShips(2)}      || {ShipCost(2)}CC        ||  {cargoCapacity(2)}       ");
            Console.WriteLine($"3. {ConvertShips(3)}       || {ShipCost(3)}CC        ||  {cargoCapacity(3)}       ");

            shipType = Utility.ErrorHandler(numOptions);

            return shipType;
       }
        internal static string ConvertShips(int shipType = 0)
        {
            string shipName = "";
            switch (shipType)
            {
                case 1:
                    shipName = "Simple Simon'";
                    break;
                case 2:
                    shipName = "Space Knight";
                    break;
                case 3:
                    shipName = "Avenger Jet";
                default:
                    break;

            }
            return shipName;
        }
        internal static int ShipCost(int shipType= 0)
        {
            int cost = 0;
                switch(shipType)
                {
                 case 1:
                    cost = 000;
                    break;
                case 2:
                    cost = 1500;
                    break;
                case 3:
                    cost = 2500;
                default:
                    break;




                }


        }
        
        
        
       
    }
}
