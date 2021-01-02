using _01._Logger.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Logger
{
    public class FileAppender : Appender
    {
        private LogFile File { get; set; }


        public FileAppender(ILayout layout, ReportLevel reportLevel) : base(layout, reportLevel)
        {
            this.File = new LogFile();
        }

        public override void Append(string dateTime, string report, string message)
        {
            int index = (int)Enum.Parse(ReportLevel.GetType(), report);
            if(index >= (int)ReportLevel)
            {
                string text = string.Format(Layout.Format, dateTime, report, message) + Environment.NewLine;
                File.Write(text);
                this.MessageCount++;
            }
            
            
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.ReportLevel}, Messages appended: {this.MessageCount}, File size: {this.File.Size}";
        }
    }
}
