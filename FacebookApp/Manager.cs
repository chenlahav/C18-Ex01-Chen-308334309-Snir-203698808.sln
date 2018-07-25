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
    public class Manager : IDisposable
    {
        private ConnectionService m_ConnectionService;

        public Manager(string i_AppID)
        {
            m_ConnectionService = new ConnectionService(i_AppID);
        }

        public bool Login()
        {
            bool connectionSucsses;

            if(m_ConnectionService.Login() != null)
            {
                connectionSucsses = true;
            }
            else
            {
                connectionSucsses = false;
            }

            return connectionSucsses;
        }

        public List<User> GetAllFriends(User i_User = null)
        {
            User user;
            if(i_User == null)
            {
                user = m_ConnectionService.loggedInUser;
            }
            else
            {
                user = i_User;
            }

            return UserHandler.GetFriends(user);
        }

        public string GetUserBirthday(User i_User = null)
        {
            User user;
            if (i_User == null)
            {
                user = m_ConnectionService.loggedInUser;
            }
            else
            {
                user = i_User;
            }
            return UserHandler.GetBirthday(user);
        }

        public List<Event> GetAllEvents(User i_User = null)
        {
            User user;
            if (i_User == null)
            {
                user = m_ConnectionService.loggedInUser;
            }
            else
            {
                user = i_User;
            }
            return UserHandler.GetEvents(user);
        }

        public string GetFirstName(User i_User = null)
        {
            User user;
            if (i_User == null)
            {
                user = m_ConnectionService.loggedInUser;
            }
            else
            {
                user = i_User;
            }
            return UserHandler.GetName(user);
        }

        public string GetLastName(User i_User = null)
        {
            User user;
            if (i_User == null)
            {
                user = m_ConnectionService.loggedInUser;
            }
            else
            {
                user = i_User;
            }
            return UserHandler.GetLastName(user);
        }

        public string GetEmail(User i_User = null)
        {
            User user;
            if (i_User == null)
            {
                user = m_ConnectionService.loggedInUser;
            }
            else
            {
                user = i_User;
            }
            return UserHandler.GetEmail(user);
        }

        public string GetURLNormalPicture(User i_User = null)
        {
            User user;
            if (i_User == null)
            {
                user = m_ConnectionService.loggedInUser;
            }
            else
            {
                user = i_User;
            }

            return UserHandler.GetURLNormalPicture(user);
        }

        public string GetURLSmallPicture(User i_User = null)
        {
            User user;
            if (i_User == null)
            {
                user = m_ConnectionService.loggedInUser;
            }
            else
            {
                user = i_User;
            }

            return UserHandler.GetURLSmallPicture(user);
        }

        public bool PostHappyBirthday(User i_UserToTag, User i_PostedUser = null)
        {
            User user;
            if(i_PostedUser == null)
            {
                user = m_ConnectionService.loggedInUser;
            }
            else
            {
                user = i_PostedUser;
            }
            return PostCreator.CreateHappyBirthdayPost(user, i_UserToTag);
        }

        public bool isUserBirthdayToday(User i_User = null)
        {
            if(i_User == null)
            {
                return BirthdayHandler.isUserBirthdayToday(m_ConnectionService.loggedInUser.Birthday);
            }
            else
            {
                return BirthdayHandler.isUserBirthdayToday(i_User.Birthday);
            }
            
        }

        public void Dispose()
        {
            m_ConnectionService.Logout();
        }
    }
}
