using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEPirate
{
    class Utility
    {
        public static int ErrorHandler(int option = 0, int numOptions = 3)
        {
            Boolean answer = false;

            while (option < 1 || option > numOptions)
            {
                do
                {
                    try
                    {
                        option = int.Parse(Console.ReadLine());
                        answer = true;
                    }
                    catch (Exception)
                    {
                        Console.Write("Please enter a valid option:  ");
                        answer = false;
                    }
                } while (answer == false);

                if (option < 1 || option > numOptions)
                {
                    Console.Write("Please enter a valid option:  ");
                }
                else { }
            }

            return option;
        }
    }
}
