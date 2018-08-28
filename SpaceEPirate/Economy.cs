using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEPirate
{
    class Economy
    {

        internal static int BuyGoods(int goodType = 0)
        {
            int option = 0;
            int numOptions = 4;
            Boolean answer = false;

            Console.WriteLine($"Please enter the number for the good you would like to purchase");
            Console.WriteLine($"=========================================================================");
            Console.WriteLine($"Item                 || Cost per Unit    || Cargo space required per unit");
            Console.WriteLine($"1. {ConvertNumberGoods(1)}            || {UnitCost(1)}CC             || {UnitSize(1)} ");
            Console.WriteLine($"2. {ConvertNumberGoods(2)}               || {UnitCost(2)}CC             || {UnitSize(2)} ");
            Console.WriteLine($"3. {ConvertNumberGoods(3)}              || {UnitCost(3)}CC            || {UnitSize(3)} ");
            Console.WriteLine($"4. {ConvertNumberGoods(4)}            || {UnitCost(4)}CC             || {UnitSize(4)} ");
            Console.WriteLine($"5. {ConvertNumberGoods(5)}      || {UnitCost(5)}CC           || {UnitSize(5)} ");
            Console.WriteLine($"6. {ConvertNumberGoods(6)}    || {UnitCost(6)}CC            || {UnitSize(6)} ");
            Console.WriteLine($"7. {ConvertNumberGoods(7)}              || {UnitCost(7)}CC            || {UnitSize(7)} ");

            option = Utility.ErrorHandler(numOptions);        }

        internal static string ConvertNumberGoods(int goodType = 0)
        {
            string goodName = "";
            switch (goodType)
            {
                case 1:
                    goodName = "Cotton";
                    break;
                case 2:
                    goodName = "Oil";
                    break;
                case 3:
                    goodName = "Gold";
                    break;
                case 4:
                    goodName = "Silver";
                    break;
                default:
                    break;
            }
            return goodName;
        }

        internal static int TotalCost(int goodType = 0, int credits = 0, int cargoRoom = 100)
        {
            int totalCost = 0;
            int newCargo = 0;
            int quantity = 0;
            Boolean answer = false;
            Boolean insufficient = true;

            do
            {
                Console.Write($"How much of {ConvertNumberGoods(goodType)} do you want to purchase?  ");
                do
                {
                    try
                    {
                        quantity = int.Parse(Console.ReadLine());
                        answer = true;
                    }
                    catch (Exception)
                    {
                        Console.Write("Please enter a number:  ");
                        answer = false;
                    }
                } while (answer == false);

                totalCost = UnitCost(goodType) * quantity;
                newCargo = UnitSize(goodType) * quantity;

                if (totalCost > credits)
                {
                    Console.WriteLine($"Insufficient funds.  You have {credits}cc and {quantity} of {ConvertNumberGoods(goodType)} costs {totalCost}");
                    Console.WriteLine("Please try again.");
                    insufficient = true;
                }
                else if (newCargo > cargoRoom)
                {
                    Console.WriteLine($"Insufficient cargo space.  You need {newCargo} space and you only have {cargoRoom}.");
                    Console.WriteLine("Please try again.");
                    insufficient = true;
                }
                else
                {
                    insufficient = false;
                }
            } while (insufficient == true);

            return quantity;
        }

        internal static int UnitCost(int goodType = 0)
        {
            int cost = 0;

            switch(goodType)
            {
                case 1:
                    cost = 50;
                    break;
                case 2:
                    cost = 20;
                    break;
                case 3:
                    cost = 100;
                    break;
                case 4:
                    cost = 75;
                    break;
                case 5:
                    cost = 1000;
                    break;
                case 6:
                    cost = 250;
                    break;
                case 7:
                    cost = 500;
                    break;
                default:
                    break;
            }

            return cost;
        }

        internal static int UnitSize(int goodType = 0)
        {
            int cargoSize = 0;

            switch (goodType)
            {
                case 1:
                    cargoSize = 1;
                    break;
                case 2:
                    cargoSize = 2;
                    break;
                case 3:
                    cargoSize = 3;
                    break;
                case 4:
                    cargoSize = 4;
                    break;
                case 5:
                    cargoSize = 10;
                    break;
                case 6:
                    cargoSize = 6;
                    break;
                case 7:
                    cargoSize = 7;
                    break;
                default:
                    break;
            }
            return cargoSize;
        }

    }
}