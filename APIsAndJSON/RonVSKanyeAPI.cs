using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        public static void ConversationSim(int loops)
        {
            for (var i = 0; i < loops; i++)
            {
                RonQuoteGenerator.RonQuote();
                Thread.Sleep(1000);
                KanyeQuoteGenerator.KanyeQuote();
                Thread.Sleep(1000);
            }
        }
    }
}
