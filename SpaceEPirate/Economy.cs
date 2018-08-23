using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEPirate
{
    class Economy
    {

        internal static int Goods(int goodType = 0)
        {
            Boolean answer = false;

            Console.WriteLine($"Please enter the number for the good you would like to purchase");
            Console.WriteLine($"=========================================================================");
            Console.WriteLine($"Item                 || Cost per Unit    || Cargo space required per unit");
            Console.WriteLine($"1. {ConvertNumberGoods(1)}            || {UnitCost(1)}CC            || 2 ");
            Console.WriteLine($"2. {ConvertNumberGoods(2)}               || {UnitCost(2)}CC            || 1 ");
            Console.WriteLine($"3. {ConvertNumberGoods(3)}              || {UnitCost(3)}CC            || 5 ");
            Console.WriteLine($"4. {ConvertNumberGoods(4)}            || {UnitCost(4)}CC             || 4 ");
            Console.WriteLine($"5. {ConvertNumberGoods(5)}      || {UnitCost(5)}CC              || 10 ");
            Console.WriteLine($"6. {ConvertNumberGoods(6)}    || {UnitCost(6)}CC             || 5 ");
            Console.WriteLine($"7. {ConvertNumberGoods(7)}              || {UnitCost(7)}CC             || 10 ");

            while (goodType < 1 || goodType > 5)
            {
                do
                {
                    try
                    {
                        goodType = int.Parse(Console.ReadLine());
                        answer = true;
                    }
                    catch (Exception)
                    {
                        Console.Write("Please enter a valid good ID number:  ");
                        answer = false;
                    }
                } while (answer == false);

                if (goodType < 1 || goodType > 7)
                {
                    Console.Write("Please enter a valid good ID number:  ");
                }
                else { }
            }
            return goodType;
        }

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
                case 5:
                    goodName = "Diamond dust";
                    break;
                case 6:
                    goodName = "Ship Batteries";
                    break;
                case 7:
                    goodName = "Wood";
                    break;
                default:
                    break;
            }
            return goodName;
        }

        internal static int TotalCost(int goodType = 0, int credits = 0, int cargoRoom = 0)
        {
            int totalCost = 0;
            int totalCargo = 0;
            int quantity = 0;
            Boolean answer = false;

            Console.Write($"How much do you want to purchase?  ");
            do
            {
                try
                {
                    quantity = int.Parse(Console.ReadLine());
                    answer = true;
                }
                catch (Exception)
                {
                    Console.Write("Please enter a valid number:  ");
                    answer = false;
                }
            } while (answer == false);

            totalCost = UnitCost(goodType) * quantity;

            if (totalCost > credits)
            {
                Console.WriteLine($"Insufficient funds.  You have {credits}cc and {quantity} of {ConvertNumberGoods(goodType)} costs {totalCost}");
                Console.WriteLine("Please try again.");
                Console.ReadLine();
                Console.Clear();
                TotalCost(goodType, credits, cargoRoom);
            }
            else if (cargoRoom >  cargoSpace)
            {

            }

            return totalCost;
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

    }
}