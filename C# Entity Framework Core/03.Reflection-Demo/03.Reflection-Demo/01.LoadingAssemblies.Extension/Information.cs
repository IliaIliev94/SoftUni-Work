namespace LoadingAssemblies.Extension
{
    using System.Reflection;

    public class Information
    {
        public string GetInfo()
        {
            return "LoadingAssemblies.Extension Executing Assembly: " + Assembly.GetExecutingAssembly().FullName + "\n" +
                   "LoadingAssemblies.Extension Calling Assembly: " + Assembly.GetCallingAssembly().FullName + "\n" +
                   "LoadingAssemblies.Extension Entry Assembly: " + Assembly.GetEntryAssembly()?.FullName;
        }
    }
}
