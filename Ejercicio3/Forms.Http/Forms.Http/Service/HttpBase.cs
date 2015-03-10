using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Forms.Http.Service
{
    public class HttpBase
    {
        protected readonly string BaseUrl;

        public HttpBase()
        {
            BaseUrl = "http://api.geonames.org/";

        }

        public async Task<string> GetAsync(string url)
        {
            return await GetAsync(url, false);
        }

        public async Task<string> GetAsync(string url, bool addToken)
        {
            var data = "";
            using (var client = new HttpClient())
            {
                if (addToken) AddAccessToken(client);
                var response = await client.GetAsync(string.Format("{0}{1}", BaseUrl, url));
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    data = await response.Content.ReadAsStringAsync();
                }
            }
            return data;
        }
        protected string Token { get; set; }
        public void AddAccessToken(HttpClient client)
        {
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Token);
        }



        public T DeserializeObject<T>(string data) where T : new()
        {
            return (!string.IsNullOrEmpty(data)) ? JsonConvert.DeserializeObject<T>(data) : new T();
        }



    }
}
