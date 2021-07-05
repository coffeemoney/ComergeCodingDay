using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace CodingDay.Tests.Extensions
{
    public static class HttpResponseMessageExtension
    {
        public static async Task<T> GetAsync<T>(this HttpResponseMessage response)
        {
            var bodyStr = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrEmpty(bodyStr))
                return default(T);

            return JsonConvert.DeserializeObject<T>(bodyStr);
        }
    }
}
