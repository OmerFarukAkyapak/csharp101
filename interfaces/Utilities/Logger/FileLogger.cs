using System;

namespace interfaces
{
    //FileLogger has a dependency on ILogger
    public class FileLogger : ILogger
    {
        //FileLogger implements the Log method from ILogger
        public void Log()
        {
            Console.WriteLine("File Logger is logging...");
        }
    }
}