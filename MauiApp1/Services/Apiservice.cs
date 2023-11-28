using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wheatherapp.models;

namespace Wheatherapp.Services
{
    public static class Apiservice
    {
        public static async Task<Root>GetWeather(double latitude, double longitude)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?q=Taichung&units=metric&lang=zh_tw&appid=a76f705c29ede1b49a7ad83d9119c8e4"));
            return JsonConvert.DeserializeObject<Root>(response);
        }
        public static async Task<Root>GetWheatherByCity(string city)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?q=Taichung&units=metric&lang=zh_tw&appid=a76f705c29ede1b49a7ad83d9119c8e4"));
            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
}
