using Newtonsoft.Json;
using RestSharp;

namespace MyDocs.Application.IntegrationTests.Extensions
{
    public static class RestExtensions
    {
        public static T ReadJsonResponse<T>(this IRestResponse request)
        {
            return JsonConvert.DeserializeObject<T>(request.Content);
        }
    }
}
