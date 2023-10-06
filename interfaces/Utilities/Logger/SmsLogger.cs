using System;

namespace interfaces
{
    //SmsLogger has a dependency on ILogger
    public class SmsLogger : ILogger
    {
        //SmsLogger implements the Log method from ILogger
        public void Log()
        {
            Console.WriteLine("Sms Logger is logging...");
        }
    }
}