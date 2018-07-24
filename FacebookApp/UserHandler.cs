using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    static class UserHandler
    {
        public static string GetName(User i_User)
        {
            return i_User.FirstName;
        }

        public static string GetLastName(User i_User)
        {
            return i_User.LastName;
        }

        public static string GetEmail(User i_User)
        {
            return i_User.Email;
        }

        public static string GetBirthday(User i_User)
        {
            return i_User.Birthday;
        }

        public static string GetURLNormalPicture(User i_User)
        {
            return i_User.PictureNormalURL;
        }

        public static string GetURLSmallPicture(User i_User)
        {
            return i_User.PictureSmallURL;
        }

        public static List<User> GetFriends(User i_User)
        {
            List<User> o_FriendsList = new List<User>();

            foreach (User friend in i_User.Friends)
            {
                o_FriendsList.Add(friend);
            }
            return o_FriendsList;
        }

        public static List<Event> GetEvents(User i_User)
        {
            List<Event> o_EventList = new List<Event>();

            foreach (Event evnt in i_User.Events)
            {
                o_EventList.Add(evnt);
            }

            return o_EventList;
        }
    }
}
