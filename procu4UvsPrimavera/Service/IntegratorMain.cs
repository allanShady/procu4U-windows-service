using procu4UvsPrimavera.Utilities;
using System;
using System.IO;
using System.Timers;

namespace procu4UvsPrimavera.Service
{
    public class IntegratorMain
    {
        private readonly Timer _timer;

        public IntegratorMain()
        {
            _timer = new Timer(1000) { AutoReset = true };
            _timer.Elapsed += TimerElapsed;
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            string[] lines = new string[] { DateTime.Now.ToString() };
            File.AppendAllLines(@"C:\PRISERVER\procu4Ufiles\UnitLog\UnitLogs.txt", lines);
            //var a = UnitsProcessor2.GetUnits(2).Result;
        }

        public void Start()
        {            
            _timer.Start();
            Console.WriteLine("Abcd");
            //var a = UnitProcessor.GetUnits(2).Result;
            //var a = UnitProcessor.GetUnits(2).Result;
        }

        public void Stop()
        {
            _timer.Stop();
        }
    }
}
