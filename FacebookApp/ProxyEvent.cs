using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp
{
    public static class ProxyEvent
    {
        public static List<EventWithWeather> GetAllEvents(User user)
        {
            List<Event> listOfEvent = UserHandler.GetEvents(user);

            List<EventWithWeather> o_ListOfEventWithWeather = new List<EventWithWeather>();
            foreach (Event evnt in listOfEvent)
            {
                o_ListOfEventWithWeather.Add(new EventWithWeather(evnt));
            }
            return o_ListOfEventWithWeather;
        }
    }
}
