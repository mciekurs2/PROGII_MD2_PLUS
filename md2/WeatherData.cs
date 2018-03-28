using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace md2
{
    internal class WeatherData
    {
        public WeatherData(string city)
        {
            this.City = city;
        }

        public void CheckWeather()
        {
            var dataApi = new WeatherApi(City);
            Temp = dataApi.GetTemp();
        }

        //dabu pilsetu
        private string City { get; set; } 
        //dabu temperaturu
        public float Temp { get; private set; }
        //dabu maksimalo temperaturu
        public float TempMax { get; set; }

        public float TempMin { get; set; }
    }

    internal class WeatherApi
    {
        public WeatherApi(string city)
        {
            SetCurrentUrl(city);
            _xmlDocument = GetXml(_currentUrl);
        }

        //pievieno parejas metodes, lai pastradatu datus
        public float GetTemp()
        {
            var tempNode = _xmlDocument.SelectSingleNode("//temperature");
            var tempValue = tempNode.Attributes["value"];
            var tempString = tempValue.Value;
            return float.Parse(tempString);
        }

        private const string Apikey = "02960f011b3cb23776734af3fa9fdf50";
        private string _currentUrl;
        private readonly XmlDocument _xmlDocument;

        private void SetCurrentUrl(string location)
        {
            _currentUrl = "http://api.openweathermap.org/data/2.5/weather?q="
                         + location + "&mode=xml&units=metric&APPID=" + Apikey;
        }

        private static XmlDocument GetXml(string currentUrl)
        {
            using (var client = new WebClient())
            {
                var xmlContent = client.DownloadString(currentUrl);
                var xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xmlContent);
                return xmlDocument;
            }
        }



    }
}
