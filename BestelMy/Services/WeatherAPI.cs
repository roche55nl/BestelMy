using BestelMy.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BestelMy.Services
{
    class WeatherAPI
    {
        public const string OPENWEATHERMAP_API_KEY = "ece317b574b62dbc425b34aedcc2a774";
        public const string BASE_URL = "https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&units={2}&appid={3}";
        // public const string BASE_URL = "http://api.openweathermap.org/data/2.5/weather?q=Diegem&apikey=39ddd9aad02c613ecfed872735e71d12&mode=json&units=metric";
        public static async Task<OneCallAPI> GetOneCallAPIAsync(double lat, double lon, string units)
        {
            OneCallAPI weather = new OneCallAPI();
            string url = String.Format(BASE_URL, lat, lon, units, OPENWEATHERMAP_API_KEY);
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var posts = JsonConvert.DeserializeObject<OneCallAPI>(content);
                weather = posts;
            }
            return weather;
        }
    }
}
