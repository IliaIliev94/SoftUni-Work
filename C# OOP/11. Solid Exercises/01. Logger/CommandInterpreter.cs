using _01._Logger.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Logger
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public void Execute(ILogger logger, string error, string dateTime, string message)
        {
            switch(error)
            {
                case "ERROR":
                    logger.Error(dateTime, message);
                    break;
                case "WARNING":
                    logger.Warning(dateTime, message);
                    break;
                case "INFO":
                    logger.Info(dateTime, message);
                    break;
                case "CRITICAL":
                    logger.Critical(dateTime, message);
                    break;
                case "FATAL":
                    logger.Fatal(dateTime, message);
                    break;
            }
        }
    }
}
