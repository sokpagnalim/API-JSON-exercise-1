using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace KanyeWest
{
    public static class Kanye
    {
        public static string GetQuote()
        {
        var client = new HttpClient();// allow application to connect to the web
        var kanyeURL = "https://api.kanye.rest/";// hold URL
        var kanyeResponse = client.GetStringAsync(kanyeURL).Result;//read request to specified URL 
        var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
        return kanyeQuote;
        }

    }

}
