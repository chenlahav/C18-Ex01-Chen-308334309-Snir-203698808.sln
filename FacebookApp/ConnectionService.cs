using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    public class ConnectionService : connectionServiceBase
    {
        private string m_AppID;
        public User loggedInUser { get; private set; }

        public override User GetLoggedInUser()
        {
            return loggedInUser;
        }

        public ConnectionService(string i_AppID)
        {
            m_AppID = i_AppID;
        }

        public override User Login()
        {
            try
            {
                LoginResult result = FacebookService.Login(m_AppID,
                    "email",
                    "public_profile",
                    "user_friends",
                    "user_events",
                    "user_birthday",
                    "user_posts"
                    );
                loggedInUser = result.LoggedInUser;
            }
            catch (Exception e)
            {
                loggedInUser = null;
            }

            return loggedInUser;
        }

        public void Logout()
        {
            Login();
        }

        public override void Dispose()
        {
            Logout();
        }

    }
}
