using _01._Logger.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Logger
{
    public class Logger : ILogger
    {
        public List<IAppender> Appender { get; }
        public Logger(params IAppender[] appender)
        {
            Appender = new List<IAppender>();
            for(int i = 0; i < appender.Length; i++)
            {
                Appender.Add(appender[i]);
            }
        }
        public void Error(string dateTime, string message)
        {
            Appender.ForEach(x => x.Append(dateTime, "Error", message));
        }

        public void Info(string dateTime, string message)
        {
            Appender.ForEach(x => x.Append(dateTime, "Info", message));
        }

        public void Warning(string dateTime, string message)
        {
            Appender.ForEach(x => x.Append(dateTime, "Warning", message));
        }

        public void Critical(string dateTime, string message)
        {
            Appender.ForEach(x => x.Append(dateTime, "Critical", message));
        }

        public void Fatal(string dateTime, string message)
        {
            Appender.ForEach(x => x.Append(dateTime, "Fatal", message));
        }
    }
}
