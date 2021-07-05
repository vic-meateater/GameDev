using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WeatherApp
{
    class DataProvider
    {

        static Dictionary<string, string> urls;
        static Dictionary<string, string> cityList;

        static DataProvider()
        {
            urls = new Dictionary<string, string>();
            urls.Add("Челябинск", @"https://xml.meteoservice.ru/export/gismeteo/point/11.xml");
            cityList = new Dictionary<string, string>();
            cityList.Add("Челябинск", @"https://xml.meteoservice.ru/export/gismeteo/point/11.xml");
            cityList.Add("Другой 1", @"https://xml.meteoservice.ru/export/gismeteo/point/56.xml");
            cityList.Add("Другой 2", @"https://xml.meteoservice.ru/export/gismeteo/point/14.xml");
        }
        HttpClient httpClient;
        public DataProvider()
        {
            httpClient = new HttpClient();
        }

        public ObservableCollection<WeatherModels> GetWeatherModels()
        {
            ObservableCollection<WeatherModels> temp = new ObservableCollection<WeatherModels>();

            foreach (var url in urls)
            {
                var req = httpClient.GetStringAsync(url.Value).Result;
                var colWeather = XDocument.Parse(req)
                                            .Descendants("MMWEATHER")
                                            .Descendants("REPORT")
                                            .Descendants("TOWN")
                                            .Descendants("FORECAST")
                                            .ToList();
                temp.Add(
                        new WeatherModels()
                        {
                            CityName = url.Key,
                            PRESSURE = colWeather[0].Element("PRESSURE").Attribute("max").Value,
                            TEMPERATURE = colWeather[0].Element("TEMPERATURE").Attribute("max").Value
                        }
                );
            }

            return temp;
        }
        public ObservableCollection<CitiesModel> GetCitiesModel()
        {
            ObservableCollection<CitiesModel> city = new ObservableCollection<CitiesModel>();

            foreach (var cty in cityList)
            {
                var req = httpClient.GetStringAsync(cty.Value).Result;
                var colWeather = XDocument.Parse(req)
                                            .Descendants("TOWN")
                                            .ToList();
                city.Add(
                        new CitiesModel()
                        {
                            CityName = cty.Key,
                        }
                );
            }

            return city;
        }
    }
}
