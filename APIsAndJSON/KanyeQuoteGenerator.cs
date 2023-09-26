using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class KanyeQuoteGenerator
    {
        public static void KanyeQuote()
        {
            var Client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest/";
            var kanyeResponse = Client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            Console.WriteLine("------------------------");
            Console.WriteLine($"Kanye West: {kanyeQuote}");
        }
    }
}
