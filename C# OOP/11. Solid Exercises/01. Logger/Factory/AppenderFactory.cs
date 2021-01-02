using _01._Logger.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Logger.Factory
{
    public class AppenderFactory : IAppenderFactory
    {
        public IAppender CreateAppender(string type, ILayout layout, ReportLevel reportLevel)
        {
            IAppender appender = null;
            if(type.Equals("ConsoleAppender"))
            {
                appender = new ConsoleAppender(layout, reportLevel);
            }
            else if(type.Equals("FileAppender"))
            {
                appender = new FileAppender(layout, reportLevel);
            }
            return appender;
        }
    }
}
