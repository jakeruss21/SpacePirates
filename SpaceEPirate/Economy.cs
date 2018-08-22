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

            Console.WriteLine("Please enter the number for the good you would like to purchase");
            Console.WriteLine("1. Cotton");
            Console.WriteLine("2. Oil");
            Console.WriteLine("3. Gold");
            Console.WriteLine("4. Silver");
            Console.WriteLine("5. Diamond dust");
            Console.WriteLine("6. Ship Batteries");
            Console.WriteLine("7. Wood");

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
    }
}