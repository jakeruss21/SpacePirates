﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEPirate
{
    class Economy
    {

        internal static int BuyGoods(int goodType = 0)
        {
            int numOptions = 4;

            Console.WriteLine($"Please enter the number for the good you would like to purchase");
            Console.WriteLine($"=========================================================================");
            Console.WriteLine($"Item                 || Cost per Unit    || Cargo space required per unit");
            Console.WriteLine($"1. {ConvertNumberGoods(1)}            || {UnitCost(1)}CC             || {UnitSize(1)} ");
            Console.WriteLine($"2. {ConvertNumberGoods(2)}               || {UnitCost(2)}CC             || {UnitSize(2)} ");
            Console.WriteLine($"3. {ConvertNumberGoods(3)}              || {UnitCost(3)}CC            || {UnitSize(3)} ");
            Console.WriteLine($"4. {ConvertNumberGoods(4)}            || {UnitCost(4)}CC             || {UnitSize(4)} ");

            goodType = Utility.ErrorHandler(numOptions);

            return goodType;
        }

        internal static string ConvertNumberGoods(int goodType = 0)
        {
            string goodName = "";
            switch (goodType)
            {
                case 1:
                    goodName = "Oil";
                    break;
                case 2:
                    goodName = "Silver";
                    break;
                case 3:
                    goodName = "Gold";
                    break;
                case 4:
                    goodName = "Titanium";
                    break;
                default:
                    break;
            }
            return goodName;
        }

        internal static int TotalCost(int goodType = 0, int credits = 0, int cargoRoom = 100)
        {
            double totalCost = 0;
            int newCargo = 0;
            int quantity = 0;
            Boolean insufficient = true;

            do
            {
                Console.Write($"How much of {ConvertNumberGoods(goodType)} do you want to purchase?  ");

                quantity = Utility.ErrorHandler(1000000);

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
                    cost = 100;
                    break;
                case 3:
                    cost = 150;
                    break;
                case 4:
                    cost = 200;
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
                default:
                    break;
            }
            return cargoSize;
        }

    }
}