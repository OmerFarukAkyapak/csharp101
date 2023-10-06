using System;

namespace interfaces;

class Program
{
    static void Main(string[] args)
    {
        //The DBLogger class has a dependency on ILogger
        DBLogger dbLogger = new DBLogger();
        dbLogger.Log();

        //The SmsLogger class has a dependency on ILogger
        SmsLogger smsLogger = new SmsLogger();
        smsLogger.Log();

        //The LogManager class has a dependency on ILogger
        //The LogManager class uses the ILogger dependency to log a message
        LogManager fileLogManager = new LogManager(new FileLogger());
        fileLogManager.Log();

        Console.ReadLine();
    }
}
