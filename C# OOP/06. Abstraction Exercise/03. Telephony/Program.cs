using System;

namespace _03._Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] websites = Console.ReadLine().Split();

            foreach(var number in numbers)
            {
                if (number.Length == 7)
                {
                    IStationaryPhone stationaryPhone = new StationaryPhone();
                    stationaryPhone.Calling(number);
                }
                else
                {
                    ISmartPhone smartPhone = new SmarthPhone();
                    smartPhone.Calling(number);
                }
            }
            foreach(var website in websites)
            {
                ISmartPhone smartPhone = new SmarthPhone();
                smartPhone.Browsing(website);
            }
        }
    }
}
