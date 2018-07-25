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
        internal static string GetName(Event i_Event)
        {
            return i_Event.Name;
        }

        internal static string GetPlaceCity(Event i_Event)
        {
            return i_Event.Place != null ? i_Event.Place.Location.City : "";
        }

        internal static string GetDescription(Event i_Event)
        {
            return i_Event != null ? i_Event.Description : "";
        }

        internal static string GetTime(Event i_Event)
        {
            return i_Event.TimeString;
        }

        internal static string GetPicture(Event i_Event)
        {
            return i_Event.PictureSmallURL;
        }
    }
}
