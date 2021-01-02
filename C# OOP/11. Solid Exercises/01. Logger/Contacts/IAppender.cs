using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Logger.Contacts
{
    public enum ReportLevel
    {
        Info,
        Warning,
        Error,
        Critical,
        Fatal
    }
    public interface IAppender
    {
        ILayout Layout { get; }

        int MessageCount { get; }

        ReportLevel ReportLevel { get; set; }
        void Append(string dateTime, string report, string message);

        string ToString();
    }
}
