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
                    Console.Write("Please enter a good planet ID:  ");
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
            
            Console.WriteLine($"You have purchase: {goodName}.");
            Console.ReadLine();
            Console.Clear();
            return goodName;
        }
    }
}