using System;

namespace interfaces
{
    public class LogManager
    {
        //LogManager has a dependency on ILogger
        private readonly ILogger _logger;

        //LogManager has a constructor that takes an ILogger
        public LogManager(ILogger logger)
        {
            _logger = logger;
        }

        //LogManager uses the ILogger dependency to log a message
        public void Log()
        {
            _logger.Log();
        }
    }

}