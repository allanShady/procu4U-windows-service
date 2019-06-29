using procu4UvsPrimavera.API.Domain;
using procu4UvsPrimavera.Utilities;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace procu4UvsPrimavera.Service
{
    public class UnitProcessor
    {
        public static void GetUnitById(HttpClient ApiWebClient, int id)
        {
            var HttpResponseMessage = UnitsProcessor2.GetDataAsync(ApiWebClient, ApiEndPoints.UNITS, id).Result;
            
            if (HttpResponseMessage.IsSuccessStatusCode)
            {
                Unit unit = HttpResponseMessage.Content.ReadAsAsync<Unit>().Result;

                //Logg success .........
                //Console.WriteLine($"Unit  : {unit.Id} - {unit.Name} - {unit.Description}");
                string[] lines = new string[] {$"Action: [Get] - Status: [{HttpResponseMessage.IsSuccessStatusCode}]" , $"[{DateTime.Now.ToString()}] - Id: {unit.Id}, Unit: {unit.Name}, Description: {unit.Description}"};
                File.AppendAllLines(@"C:\PRISERVER\procu4Ufiles\UnitLog\UnitLogs.txt", lines);
            }
            else
            {
                //Console.WriteLine("Failed to post data");
                string[] lines = new string[] { $"Action: [Get] - Status: [{HttpResponseMessage.IsSuccessStatusCode}] Object Id: [{id}]" };
                File.AppendAllLines(@"C:\PRISERVER\procu4Ufils\UnitLog\UnitLogs.txt", lines);
            }
        }

        public static void PostUnit(HttpClient ApiWebClient, Unit unit)
        {
            var HttpResponseMessage = UnitsProcessor2.PostDataAsync(ApiWebClient, ApiEndPoints.UNITS, unit).Result;

            if (HttpResponseMessage.IsSuccessStatusCode)
            {
                var responseData = HttpResponseMessage.Content.ReadAsAsync<Unit>().Result;

                //Logg success .........
                //Console.WriteLine($"Unit  : {unit.Id} - {unit.Name} - {unit.Description}");
                string[] lines = new string[] { $"Action: [Get] - Status: [{HttpResponseMessage.IsSuccessStatusCode}]",
                    $"[{DateTime.Now.ToString()}] - Id: {responseData.Id}, Unit: {responseData.Name}, Description: {responseData.Description}" };
                File.AppendAllLines(@"C:\PRISERVER\procu4Ufiles\UnitLog\UnitLogs.txt", lines);
            }
            else
            {
                //Console.WriteLine("Failed to post data");
                string[] lines = new string[] { $"Action: [Get] - Status: [{HttpResponseMessage.IsSuccessStatusCode}]"};
                File.AppendAllLines(@"C:\PRISERVER\procu4Ufils\UnitLog\UnitLogs.txt", lines);
            }
        }


        public static void PutUnit(HttpClient ApiWebClient, int id, Unit unit)
        {
            var HttpResponseMessage = UnitsProcessor2.PutDataAsync(ApiWebClient, ApiEndPoints.UNITS, id, unit).Result;

            if (HttpResponseMessage.IsSuccessStatusCode)
            {
                var responseData = HttpResponseMessage.Content.ReadAsAsync<Unit>().Result;

                //Logg success .........
                //Console.WriteLine($"Unit  : {unit.Id} - {unit.Name} - {unit.Description}");
                string[] lines = new string[] { $"Action: [Get] - Status: [{HttpResponseMessage.IsSuccessStatusCode}]",
                    $"[{DateTime.Now.ToString()}] - Id: {responseData.Id}, Unit: {responseData.Name}, Description: {responseData.Description}" };
                File.AppendAllLines(@"C:\PRISERVER\procu4Ufiles\UnitLog\UnitLogs.txt", lines);
            }
            else
            {
                //Console.WriteLine("Failed to post data");
                string[] lines = new string[] { $"Action: [Get] - Status: [{HttpResponseMessage.IsSuccessStatusCode}]" };
                File.AppendAllLines(@"C:\PRISERVER\procu4Ufils\UnitLog\UnitLogs.txt", lines);
            }
        }

    }
}
