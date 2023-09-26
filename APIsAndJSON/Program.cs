using Newtonsoft.Json.Linq;
using System;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var mainMenu = true;
            while (mainMenu)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Please select an option or type \"exit\" to quit. \n 1: Kanye West and Ron Swanson simulated conversation \n 2: Weather by Zip code");
                var entry = Console.ReadLine();
                switch (entry.ToLower())
                {
                    case "1":
                        RonVSKanyeAPI.ConversationSim(5);
                        break;
                    case "2":
                        string key = File.ReadAllText("appsettings.json");
                        string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

                        Console.WriteLine("Please enter your zipcode.");
                        string zipCode = Console.ReadLine();

                        var apiCall = $"http://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIKey}";
                        Console.WriteLine($"It is currently {Weather.GetWeather(apiCall)}° F in your location.");
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        RonQuoteGenerator.RonQuote();
                        Environment.Exit(0);
                        break;
                }
            }
                
                


        }
    }
}
