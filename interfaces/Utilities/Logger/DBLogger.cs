using System;

namespace interfaces
{
    //DBLogger has a dependency on ILogger
    public class DBLogger : ILogger
    {
        //DBLogger implements the Log method from ILogger
        public void Log()
        {
            Console.WriteLine("DB Logger is logging...");
        }
    }
}