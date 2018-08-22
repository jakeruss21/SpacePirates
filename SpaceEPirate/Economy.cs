using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEPirate
{
    class Economy
    {

        internal static string Goods(int goodType = 0)
        {
            string goodName = "";
            Boolean answer = false;

            Console.WriteLine($"Please enter the number for the good you would like to purchase");
            Console.WriteLine($"=========================================================================");
            Console.WriteLine($"Item                 || Cost per Unit    || Cargo space required per unit");
            Console.WriteLine($"1. Cotton            || {UnitCost(1)}            || 2 ");
            Console.WriteLine($"2. Oil               || {UnitCost(2)}            || 1 ");
            Console.WriteLine($"3. Gold              || {UnitCost(3)}            || 5 ");
            Console.WriteLine($"4. Silver            || 75CC             || 4 ");
            Console.WriteLine($"5. Diamond dust      || 1000CC           || 10 ");
            Console.WriteLine($"6. Ship Batteries    || 250CC            || 5 ");
            Console.WriteLine($"7. Wood              || 75CC             || 10 ");

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

        internal static int ConvertNumberGoods(string goodName = "")
        {
            int goodType = 0;
            switch (goodName)
            {
                case "Cotton":
                    goodType = 1;
                    break;
                case "Oil":
                    goodType = 2;
                    break;
                case "Gold":
                    goodType = 3;
                    break;
                case "Silver":
                    goodType = 4;
                    break;
                case "Diamond dust":
                    goodType = 5;
                    break;
                case "Ship Batteries":
                    goodType = 6;
                    break;
                case "Wood":
                    goodType = 7;
                    break;
                default:
                    break;
            }
            return goodType;
        }

        internal static int TotalCost(int goodType = 0, int credits = 0, int cargoRoom = 0)
        {
            int totalCost = 0;
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


            }
        }

    }
}