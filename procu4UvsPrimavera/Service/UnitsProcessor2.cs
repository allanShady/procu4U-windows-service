using procu4UvsPrimavera.API.Domain;
using procu4UvsPrimavera.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace procu4UvsPrimavera.Service
{
    public static class UnitsProcessor2
    {
        public static async Task<HttpResponseMessage> GetDataAsync(HttpClient apiWebClient, string endpoint, int id)
        {      
            return await apiWebClient.GetAsync($"{endpoint}/{id}");
        }

        public static async Task<HttpResponseMessage> PostDataAsync(HttpClient apiWebClient, string endpoint, object data)
        {
            return await apiWebClient.PostAsJsonAsync($"{endpoint}", data);
        }

        public static async Task<HttpResponseMessage> PutDataAsync(HttpClient apiWebClient, string endpoint, int id, object data)
        {            
            return await apiWebClient.PutAsJsonAsync($"{endpoint}/{id}", data);               
        }

        //public static async Task<object> PutDataAsync(int id, object data)
        //{

        //    using (var apiWebClient = new HttpClient())
        //    {
        //        apiWebClient.BaseAddress = new Uri(ApiEndPoints.MAIN_END_POINT);
        //        apiWebClient.DefaultRequestHeaders.Accept.Clear();
        //        apiWebClient.DefaultRequestHeaders.Add("X-Tenant-Id", "T1_procu4U");
        //        apiWebClient.DefaultRequestHeaders.Add("x-api-key", "7BD9CDBC-B3C1-47E1-88F4-DEC98A2F7403");
        //        apiWebClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //        HttpResponseMessage httpResponseMessage = await apiWebClient.PutAsJsonAsync($"{ApiEndPoints.UNITS}/{id}", data);

        //        if (httpResponseMessage.IsSuccessStatusCode)
        //        {
        //            Unit unit2 = await httpResponseMessage.Content.ReadAsAsync<Unit>();

        //            Console.WriteLine($"Updated made : {unit2.Id} - {unit2.Name} - {unit2.Description}");
        //            return data;
        //        }

        //        return new object();
        //    }
        //}
    }
}
