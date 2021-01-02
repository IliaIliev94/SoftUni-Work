using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Logger.Contacts
{
    public interface ILogger
    {
        List<IAppender> Appender { get; }
        void Error(string dateTime, string message);

        void Info(string dateTime, string message);

        void Warning(string dateTime, string message);

        void Critical(string dateTime, string message);

        void Fatal(string dateTime, string message);

    }
}
