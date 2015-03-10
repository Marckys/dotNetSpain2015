
using System;
using System.Threading.Tasks;
using Forms.Http.Models;

namespace Forms.Http.Service
{
    public class CityService : HttpBase
    {
        public async Task<RestWrap> GetCities()
        {
            var data = await GetAsync(string.Format("citiesJSON?north={0}&south={1}&east={2}&west={3}&lang={4}&username={5}", "44.1", "-9.9", "-22.4", "55.2", "de", "demo"));

            return DeserializeObject<RestWrap>(data);


        }
    }
}
