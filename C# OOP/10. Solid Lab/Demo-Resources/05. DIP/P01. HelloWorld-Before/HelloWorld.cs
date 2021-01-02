using System;

namespace P01._HelloWorld
{
    public class HelloWorld
    {
        public string Greeting(string name, DateTime dateTime)
        {
            if (dateTime.Hour < 12)
            {
                return "Good morning, " + name;
            }

            if (dateTime.Hour < 18)
            {
                return "Good afternoon, " + name;
            }

            return "Good evening, " + name;
        }
    }
}
