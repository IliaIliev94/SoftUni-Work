using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Telephony
{
    public class StationaryPhone : IStationaryPhone
    {
        public virtual void Calling(string number)
        {
            if(ValidNumber(number))
            {
                Console.WriteLine($"Dialing... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
            
        }
        public bool ValidNumber(string number)
        {
            foreach(var character in number)
            {
                if (!char.IsDigit(character))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
