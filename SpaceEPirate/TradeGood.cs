using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEPirate
{
    class TradeGood
    {
        public string goodName = "";
        public int size = 0;
        public int quantity = 0;

        public TradeGood()
        {

        }

        public TradeGood(string iName, int iSize, int iQuantity = 0)
        {
            goodName = iName;
            size = iSize;
            quantity = iQuantity;
        }

        internal static void AddGoods(TradeGood a, int addGoods)
        {
            a.quantity += addGoods;
        }

    }
}
