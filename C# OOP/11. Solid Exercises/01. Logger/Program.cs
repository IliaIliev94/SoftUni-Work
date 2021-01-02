using _01._Logger.Contacts;
using _01._Logger.Factory;
using System;

namespace _01._Logger
{

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ILogger logger = null;
            IAppender[] appenders = new IAppender[n];
            IAppenderFactory appenderFactory = new AppenderFactory();
            ILayoutFactory layoutFactory = new LayoutFactory();
            ICommandInterpreter commandInterpreter = new CommandInterpreter();
            ILogData logData = new LogData();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string type = data[0];
                ILayout layout = layoutFactory.CreateLayout(data[1]);
                if(data.Length == 3)
                {
                    appenders[i] = appenderFactory
                        .CreateAppender(data[0], layout, (ReportLevel)Enum.Parse(typeof(ReportLevel), data[2].ToLower(), true));
                }
                else
                {
                    appenders[i] = appenderFactory.CreateAppender(data[0], layout, ReportLevel.Info);
                }
            }

            logger = new Logger(appenders);
            string command = Console.ReadLine();

            while(!command.Equals("END"))
            {
                string[] data = command.Split("|");
                commandInterpreter.Execute(logger, data[0], data[1], data[2]);
                command = Console.ReadLine();
            }
            logData.PrintData(logger);
        }
    }
}
