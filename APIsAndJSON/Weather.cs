﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class Weather
    {
       
        public static double GetWeather(string apiCall)
        {
            var client = new HttpClient();
            var response = client.GetStringAsync(apiCall).Result;
            var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());
            return temp;
        }                
    }
}
