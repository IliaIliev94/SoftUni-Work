using _01._Logger.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Logger
{
    public class ConsoleAppender : Appender
    {

        public ConsoleAppender(ILayout layout, ReportLevel reportLevel) : base(layout, reportLevel)
        {
        }

        public override void Append(string dateTime, string report, string message)
        {
            int index = (int)Enum.Parse(ReportLevel.GetType(), report);
            if(index >= (int)ReportLevel)
            {
                Console.WriteLine(this.Layout.Format, dateTime, report, message);
                this.MessageCount++;
            }
            
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.ReportLevel}, Messages appended: {this.MessageCount}";
        }
    }
}
