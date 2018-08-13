using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    internal static class FacebookEventHandler
    {
        internal static string GetName(EventWithWeather i_Event)
        {
            return i_Event.Event.Name;
        }

        internal static string GetPlaceCity(EventWithWeather i_Event)
        {
            return i_Event.Event.Place != null ? i_Event.Event.Place.Location.City : "";
        }

        internal static string GetDescription(EventWithWeather i_Event)
        {
            return i_Event != null ? i_Event.Event.Description : "";
        }

        internal static string GetTime(EventWithWeather i_Event)
        {
            return i_Event.Event.TimeString;
        }

        internal static string GetPicture(EventWithWeather i_Event)
        {
            return i_Event.Event.PictureSmallURL;
        }
    }
}
