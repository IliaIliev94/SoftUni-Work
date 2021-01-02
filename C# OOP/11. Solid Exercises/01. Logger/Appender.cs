using _01._Logger.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Logger
{
    public abstract class Appender : IAppender
    {
        public ILayout Layout { get; set; }

        public ReportLevel ReportLevel { get; set; }

        public int MessageCount { get; protected set; }

        protected Appender(ILayout layout, ReportLevel reportLevel)
        {
            this.Layout = layout;
            this.ReportLevel = reportLevel;
            this.MessageCount = 0;
        }

        public abstract void Append(string dateTime, string report, string message);

        public abstract string ToString();
    }
}
