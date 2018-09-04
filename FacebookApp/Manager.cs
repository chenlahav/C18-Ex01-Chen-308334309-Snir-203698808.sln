using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp
{
    public class Manager : IDisposable
    {
        private ConnectionService m_ConnectionService;
        private static Manager m_instance = null; 
        private static string m_AppID = null;
       
        private static readonly object sr_Locker =  new object();

        private Manager(string i_AppID)
        {
            m_ConnectionService = new ConnectionService(i_AppID);
        }


        public static Manager GetInstance(string i_appID = null)
        {
            m_AppID = (i_appID != null) ? i_appID : m_AppID;

            if(m_instance == null)
            {
                lock (sr_Locker)
                {
                    if (m_instance == null)
                    {
                         if (m_AppID != null)
                        {
                            m_instance = new Manager(m_AppID);
                        }
                        else
                        {
                            throw new MissingMemberException("Appip missed.");
                        }
                    }
                }
            }
            
            return m_instance;
        }


        public void SetAppId(string i_Appid)
        {
            m_AppID = i_Appid;
            m_ConnectionService = new ConnectionService(m_AppID);
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

        public List<EventWithWeather> GetAllEvents(User i_User = null)
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

            return ProxyEvent.GetAllEvents(user);
        }

        public string GetUserFirstName(User i_User = null)
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

        public string GetUserLastName(User i_User = null)
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

        public string GetUserEmail(User i_User = null)
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

        public string GetUserURLNormalPicture(User i_User = null)
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

        public string GetUserURLSmallPicture(User i_User = null)
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

        public bool PostStatus(string i_TextToPost, User i_PostedUser = null)
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

            return PostCreator.PostStatus(user, i_TextToPost);

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

        public CityWeather GetWeather(string i_cityName)
        {
            return Weather.GetWeather(i_cityName);
        }

        public string GetEventName(EventWithWeather i_Event)
        {
            return FacebookEventHandler.GetName(i_Event);
        }

        public string GetEventDescription(EventWithWeather i_Event)
        {
            return FacebookEventHandler.GetDescription(i_Event);
        }

        public string GetEventCity(EventWithWeather i_Event)
        {
            return FacebookEventHandler.GetPlaceCity(i_Event);
        }

        public string GetEventURLPicture(EventWithWeather i_Event)
        {
            return FacebookEventHandler.GetPicture(i_Event);
        }

        public string GetEventTime(EventWithWeather i_Event)
        {
            return FacebookEventHandler.GetTime(i_Event);
        }

        public string GetPathOfImageWeather(double i_Temperature)
        {
            string imageLocation;
            if (i_Temperature <= 0)
            {
                imageLocation = "..\\..\\Resources\\rainy.png";
            }
            else if (i_Temperature > 0 && i_Temperature <= 20)
            {
                imageLocation = "..\\..\\Resources\\cloudy.png";
            }
            else
            {
                imageLocation = "..\\..\\Resources\\sun.png";
            }

            return imageLocation;
        }

        public void Dispose()
        {
            m_ConnectionService.Dispose();
        }
    }
}
