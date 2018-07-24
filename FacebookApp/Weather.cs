    using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FacebookApp
{
    public static class Weather
    {
        public static double GetTemp(string i_cityName)
        {
            string weburl = string.Format("https://samples.openweathermap.org/data/2.5/weather?q="+ 
                i_cityName + "&mode=xml&appid=b6907d289e10d714a6e88b30761fae22");
            var xml = new WebClient().DownloadString(new Uri(weburl));

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
                string szTemp = doc.DocumentElement.SelectSingleNode("temperature").Attributes["value"].Value;
            double temp = double.Parse(szTemp) - 273.16;
            return temp;

        }
    }
}
