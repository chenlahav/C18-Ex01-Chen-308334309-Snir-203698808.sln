using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FacebookApp
{
    public class EventWithWeather
    {
        public string Name { get; private set; }
        public Event Event { get; private set; }
        public CityWeather CityWeather { get; private set; }
        //public double temperature { get; private set; }

        public EventWithWeather(Event i_Event)
        {
            Name = i_Event.Name;
            Event = i_Event;
            CityWeather = Weather.GetWeather(Event.Place.Location.City);
        }

    }
}
