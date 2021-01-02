using _01._Logger.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Logger
{
    public class LogData : ILogData
    {
        public void PrintData(ILogger logger)
        {
            foreach(var log in logger.Appender)
            {
                Console.WriteLine(log.ToString());
            }
        }
    }
}
