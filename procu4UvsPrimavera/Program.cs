using procu4UvsPrimavera.API.Domain;
using procu4UvsPrimavera.Service;
using procu4UvsPrimavera.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace procu4UvsPrimavera
{
    class Program
    {
        static HttpClient ApiWebClient { get; set; } = new HttpClient();
        static HttpResponseMessage HttpResponseMessage { get; set; }

        static void Main(string[] args)
        {
            InitWebClient();

            Console.WriteLine("Init Init Init Init Init");
            UnitProcessor.GetUnitById(ApiWebClient, 24);
            UnitProcessor.PutUnit(ApiWebClient, 22, 
                new Unit { Name = "Changed", Description = "Change"  });

            UnitProcessor.PostUnit(ApiWebClient, new Unit { Name = "Last One", Description = "Go and watch a movie" }); 
            
            //StART config5ure service

            var exitCode = HostFactory.Run(x =>
            {
                x.Service<IntegratorMain>(s =>
                {
                    s.ConstructUsing(integratorMain => new IntegratorMain());
                    s.WhenStarted(integratorMain => integratorMain.Start());
                    s.WhenStopped(integratorMain => integratorMain.Stop());
                });

                x.RunAsLocalSystem();

                x.SetServiceName("procu4UvsPrimavera");
                x.SetDisplayName("procu4U vs Primavera Service");
                x.SetDescription("Service that syncronize data from Primavera to procu4U. The data are coming from Products, Suppliers, Units, Departments, Orders and currencies.");
            });

            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
            Environment.ExitCode = exitCodeValue;
        }

        static void InitWebClient()
        {
                ApiWebClient.BaseAddress = new Uri(ApiEndPoints.MAIN_END_POINT);
                ApiWebClient.DefaultRequestHeaders.Accept.Clear();
                ApiWebClient.DefaultRequestHeaders.Add("X-Tenant-Id", "T1_procu4U");
                ApiWebClient.DefaultRequestHeaders.Add("x-api-key", "7BD9CDBC-B3C1-47E1-88F4-DEC98A2F7403");
                ApiWebClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); 
       }
    }
}
