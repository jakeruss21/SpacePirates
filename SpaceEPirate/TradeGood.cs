using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEPirate
{
    class TradeGood
    {
        private string goodName = "";
        private int size = 0;
        private int cost = 0;
        private int quantity = 0;

        public TradeGood()
        {

        }

        public TradeGood(string iName, int iSize, int iCost, int iQuantity = 0)
        {
            goodName = iName;
            size = iSize;
            cost = iCost;
            quantity = iQuantity;
        }

    }
}
