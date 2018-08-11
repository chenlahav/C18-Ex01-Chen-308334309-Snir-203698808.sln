using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp
{
    internal static class BirthdayHandler
    {
        internal static bool isUserBirthdayToday(string i_UserBirthday)
        {
            //return true;
           bool isBirthdayToday;
            DateTime parsedBirthDateFriend = DateTime.Parse(i_UserBirthday);
            DateTime timeNow = DateTime.Now;
            if (parsedBirthDateFriend.Day == timeNow.Day && 
                parsedBirthDateFriend.Month == timeNow.Month)
            {
                isBirthdayToday = true;
            }
            else
            {
                isBirthdayToday = false;
            }

            return isBirthdayToday;
        }
    }
}
