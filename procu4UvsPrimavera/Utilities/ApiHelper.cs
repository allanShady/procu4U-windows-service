using System.Net.Http;
using System.Net.Http.Headers;

namespace procu4UvsPrimavera.Utilities
{
    public static class ApiHelper
    {
        //public static HttpClient ApiClient { get; set; }

        //public static void InitializeClient()
        //{
        //    ApiClient = new HttpClient();
        //    ApiClient.DefaultRequestHeaders.Accept.Clear();

        //    ApiClient.DefaultRequestHeaders.Add("Content-Type", "application/json");
        //    ApiClient.DefaultRequestHeaders.Add("X-Tenant-Id", "T1_procu4U");
        //    ApiClient.DefaultRequestHeaders.Add("x-api-key", "7BD9CDBC-B3C1-47E1-88F4-DEC98A2F7403");
        //    ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //}
        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
