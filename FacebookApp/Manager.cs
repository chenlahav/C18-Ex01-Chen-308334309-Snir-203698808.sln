using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookApp
{
    static class Manager
    {

        private static User m_LoggedInUser;

        public static bool Login(string i_AppID)
        {
            bool o_IsSuccessToLogin;
            try
            {
                LoginResult result = FacebookService.Login(i_AppID,
                    "email",
                    "public_profile",
                    "user_friends",
                    "user_events",
                    "user_location",
                    "user_birthday",
                    "manage_pages",
                    "publish_pages",
                    "user_photos");
                if(result != null)
                {
                    m_LoggedInUser = result.LoggedInUser;
                    o_IsSuccessToLogin = true;
                }
                else
                {
                    o_IsSuccessToLogin = false;
                }
            }
            catch(Exception e)
            {
                o_IsSuccessToLogin = false;
            }

            return o_IsSuccessToLogin;
        }

        public static void Logout()
        {
            Login("1430451463721328");
        }

        public static List<User> GetAllFriends()
        {
            List<User> o_FriendsList = new List<User>();

            foreach (User friend in m_LoggedInUser.Friends)
            {
                o_FriendsList.Add(friend);
            }
            return o_FriendsList;
        }

        public static string GetCoverPhoto()
        {
            return m_LoggedInUser.Cover.SourceURL;
        }

        public static string GetUserBirthday()
        {
            return m_LoggedInUser.Birthday;
        }

        public static List<Event> GetAllEvents()
        {
            List<Event> o_EventList = new List<Event>();

            foreach (Event evnt in m_LoggedInUser.Events)
            {
                o_EventList.Add(evnt);
            }

            return o_EventList;
        }

        public static string GetFirstName()
        {
            string o_Name = null;
            o_Name = m_LoggedInUser.FirstName;
            return o_Name;
        }

        public static string GetLastName()
        {
            string o_LastName = null;
            o_LastName = m_LoggedInUser.LastName;
            return o_LastName ;
        }

        public static string GetEmail()
        {
            string o_Email = null;
            o_Email = m_LoggedInUser.Email;
            return o_Email;
        }

        public static string GetURLPicture()
        {
            string o_URLPicture;
            o_URLPicture = m_LoggedInUser.PictureNormalURL;
            return o_URLPicture;
        }

        public static void Post(string i_PostText, User i_UserToTag = null)
        {
            string idToTag;
            if (i_UserToTag != null)
            {
                idToTag = i_UserToTag.Id;
            }
            else
            {
                idToTag = null;
            }
            try
            {
                Status postStatus = m_LoggedInUser.PostStatus(i_PostText,i_TaggedFriendIDs: idToTag);
                MessageBox.Show($"Status Posted! ID: {postStatus.Id}");
            }
            catch(Exception e)
            {
                MessageBox.Show("Post Failed");
            }
        }
    }
}
