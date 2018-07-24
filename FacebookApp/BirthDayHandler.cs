using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp
{
    static class BirthdayHandler
    {
        public static List<User> getUserThatBirthdayOn(List<User> i_AllFriends, string i_BirthDay)
        {
            List<User> o_UsersList = new List<User>();

            foreach (User user in i_AllFriends)
            {
                if (user.Birthday.Equals(i_BirthDay))
                {
                    o_UsersList.Add(user);
                }
            }

            return o_UsersList;
        }

        public static bool isUserBirthdayToday(string i_UserBirthday)
        {
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
