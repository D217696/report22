using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace asptest6.Objects
{
    public class BungieApi
    {
        private readonly string Domain = "https://www.bungie.net/Platform/";
        private readonly string ApiKey = "0f21708074a04dc5bff0f41cea7bd65b";
        public readonly HttpClient client = new HttpClient();
        public BungieApi()
        {
            client.DefaultRequestHeaders.Add("X-API-Key", ApiKey);
        }

        public async Task<string> MakeRequest(string url)
        {
            string x = Domain + url;
            HttpResponseMessage response = await client.GetAsync($"{Domain}{url}");
            Console.WriteLine($"Request made {DateTime.Now}");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
