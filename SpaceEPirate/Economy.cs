using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEPirate
{
    class Economy
    {

        internal static int BuyGoods(TradeGood[] tradeGoods)
        {
            int numOptions = 4;
            int goodType = 0;

            Console.WriteLine($"Please enter the number for the good you would like to purchase");
            Console.WriteLine($"=========================================================================");
            Console.WriteLine($"Item                 || Cost per Unit    || Cargo space required per unit");
            Console.WriteLine($"1. {tradeGoods[0].goodName}            || {tradeGoods[0].cost}CC             || {tradeGoods[0].size} ");
            Console.WriteLine($"2. {tradeGoods[1].goodName}               || {tradeGoods[1].cost}CC             || {tradeGoods[1].size} ");
            Console.WriteLine($"3. {tradeGoods[2].goodName}              || {tradeGoods[2].cost}CC            || {tradeGoods[2].size} ");
            Console.WriteLine($"4. {tradeGoods[3].goodName}            || {tradeGoods[3].cost}CC             || {tradeGoods[3].size} ");

            goodType = Utility.ErrorHandler(numOptions);

            return goodType - 1;
        }

        internal static int TotalCost(UserProfile player, TradeGood tradeGoods, SpaceShip spaceShips)
        {
            double totalCost = 0;
            int newCargo = 0;
            int quantity = 0;
            Boolean insufficient = true;

            do
            {
                Console.Write($"How much of {tradeGoods.goodName} do you want to purchase?  ");

                quantity = Utility.ErrorHandler(1000000);

                totalCost = tradeGoods.cost * quantity;
                newCargo = tradeGoods.size * quantity;

                if (totalCost > player.cosmicCredits)
                {
                    Console.WriteLine($"Insufficient funds.  You have {player.cosmicCredits}cc and {quantity} of {tradeGoods.goodName} costs {totalCost}");
                    Console.WriteLine("Please try again.");
                    insufficient = true;
                }
                else if (newCargo > spaceShips.cargoCapacity)
                {
                    Console.WriteLine($"Insufficient cargo space.  You need {newCargo} space and you only have {spaceShips.cargoCapacity}.");
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

        internal static void MarketPlace(TradeGood[] cargoInventory, UserProfile player)
        {
            int option = 0;

            int numOptions = 2;
            Console.WriteLine($"You have {player.cosmicCredits}CC and  space available in your ship.\n");
            Console.WriteLine($"What would you like to do? \n1. Buy \n2. Sell \n3. Go to Planet Menu");

            option = Utility.ErrorHandler(numOptions);

            //switch (option)
            //{
            //    case 1:
            //        newGoods = BuyGoods(storage, credits);
            //        break;
            //    case 2:
            //        newGoods = SellGoods(storage, credits);
            //        break;
            //    default:
            //        break;
            //}

        }


    }
}