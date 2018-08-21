using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceEPirate
{
    class UserProfile
    {


        private string UserName(string userName = "")
        {
            Console.Write("Please enter the character's name:");
            userName = Console.ReadLine();
            Console.WriteLine($"Your character name is {userName}");
            Console.WriteLine($"You have {UserMoney} credits");
            return userName;
        }

        private int UserMoney(int userMoney = 1000)
        {


            return userMoney;
        }
    }
}
